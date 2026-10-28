using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using GeoLab2D.Geometry;
using GeoLab2D.Models;
using GeoLab2D.Rendering;
using GeoLab2D.Tests;
using GeoLab2D.Transformations;

namespace GeoLab2D
{
    // Formulario principal. Aquí sólo se leen los datos, se llaman las clases de
    // geometría y se muestran los resultados. Las fórmulas están en las otras clases.
    public partial class MainForm : Form
    {
        private GeometryRenderer renderer = new GeometryRenderer();
        private Transformation2D transformation = new Transformation2D();

        private List<Polygon2D> figuraOriginal = new List<Polygon2D>();     // partes que se dibujan
        private List<Polygon2D> poligonosAnalisis = new List<Polygon2D>();  // para área y pertenencia
        private Vector2D centroFigura;

        // Colores de la figura
        private Color[] coloresHexagono = { Color.Red, Color.Orange, Color.Gold, Color.LimeGreen, Color.DodgerBlue, Color.MediumPurple };
        private Color[] coloresMargarita = { Color.HotPink, Color.Orchid, Color.DeepSkyBlue, Color.MediumSeaGreen, Color.Coral, Color.Gold };
        private Color colorEstrella = Color.Orange;
        private Color colorContorno = Color.Black;

        private bool cargando = true;

        // Datos de lo que se dibuja encima de la figura (vectores, puntos, proyección)
        private string modoDibujo = "";
        private Vector2D puntoA, puntoB, puntoC, puntoP;
        private Polygon2D poligonoResaltado;
        private PointLocation ubicacion;
        private ProjectionResult proyeccion;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cargando = false;
            cboFigura.SelectedIndex = 0;
        }

        // ===================== Construcción de las figuras =====================

        private void cboFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargando = true;
            int figura = cboFigura.SelectedIndex;

            // Sólo se habilitan los parámetros que usa cada figura
            nudSeparacion.Enabled = (figura == 1);
            nudN.Enabled = (figura == 2);
            nudK.Enabled = (figura == 2);

            cboColor.Items.Clear();
            if (figura == 0)
            {
                lblLado.Text = "Lado (u):";
                nudLado.Value = 4;
                nudRotacion.Value = 0;
                for (int i = 1; i <= 6; i++) cboColor.Items.Add("Sector " + i);
            }
            else if (figura == 1)
            {
                lblLado.Text = "Lado (u):";
                nudLado.Value = 2;
                nudRotacion.Value = 90;
                for (int i = 1; i <= 5; i++) cboColor.Items.Add("Pétalo " + i);
                cboColor.Items.Add("Centro de la flor");
            }
            else
            {
                lblLado.Text = "Radio (u):";
                nudLado.Value = 5;
                nudRotacion.Value = 90;
                cboColor.Items.Add("Relleno de la estrella");
            }
            cboColor.SelectedIndex = 0;
            cargando = false;

            transformation.Reset();
            txtTransformaciones.Clear();
            modoDibujo = "";
            ConstruirFigura();
        }

        private void Parametro_ValueChanged(object sender, EventArgs e)
        {
            if (cargando) return;

            // El salto K debe ser menor que N/2
            if (sender == nudN)
                nudK.Maximum = Math.Max(1, Math.Floor((nudN.Value - 1) / 2));

            ConstruirFigura();
        }

        private void ConstruirFigura()
        {
            try
            {
                double lado = (double)nudLado.Value;
                double rotacion = (double)nudRotacion.Value;
                centroFigura = new Vector2D((double)nudCentroX.Value, (double)nudCentroY.Value);

                if (cboFigura.SelectedIndex == 0)
                {
                    figuraOriginal = PolygonFactory.CreateHexagonTriangles(centroFigura, lado, rotacion);
                    poligonosAnalisis = new List<Polygon2D>();
                    poligonosAnalisis.Add(PolygonFactory.CreateHexagon(centroFigura, lado, rotacion));
                    poligonosAnalisis.AddRange(figuraOriginal);
                }
                else if (cboFigura.SelectedIndex == 1)
                {
                    double separacion = (double)nudSeparacion.Value;
                    List<Polygon2D> petalos = PolygonFactory.CreateDaisy(centroFigura, lado, rotacion, separacion);
                    figuraOriginal = new List<Polygon2D>(petalos);
                    figuraOriginal.Add(PolygonFactory.CreateDaisyCenter(centroFigura, lado, separacion));
                    poligonosAnalisis = petalos;
                }
                else
                {
                    int n = (int)nudN.Value;
                    int k = (int)nudK.Value;
                    figuraOriginal = PolygonFactory.CreateStar(centroFigura, lado, n, k, rotacion);
                    poligonosAnalisis = figuraOriginal;
                }

                cboPoligono.Items.Clear();
                foreach (Polygon2D p in poligonosAnalisis)
                    cboPoligono.Items.Add(p.Name);
                cboPoligono.SelectedIndex = 0;

                if (modoDibujo == "poligono" || modoDibujo == "pertenencia") modoDibujo = "";
                MostrarResultados();
                picCanvas.Invalidate();
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }

        private Color ColorDeParte(int i)
        {
            if (cboFigura.SelectedIndex == 0) return coloresHexagono[i];
            if (cboFigura.SelectedIndex == 1) return coloresMargarita[i];
            // Si la estrella tiene varias partes se usa transparencia para ver los cruces
            return figuraOriginal.Count > 1 ? Color.FromArgb(170, colorEstrella) : colorEstrella;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int i = cboColor.SelectedIndex;
            ColorDialog dialogo = new ColorDialog();
            if (cboFigura.SelectedIndex == 0) dialogo.Color = coloresHexagono[i];
            else if (cboFigura.SelectedIndex == 1) dialogo.Color = coloresMargarita[i];
            else dialogo.Color = colorEstrella;

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                if (cboFigura.SelectedIndex == 0) coloresHexagono[i] = dialogo.Color;
                else if (cboFigura.SelectedIndex == 1) coloresMargarita[i] = dialogo.Color;
                else colorEstrella = dialogo.Color;
                picCanvas.Invalidate();
            }
        }

        private void btnContorno_Click(object sender, EventArgs e)
        {
            ColorDialog dialogo = new ColorDialog();
            dialogo.Color = colorContorno;
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                colorContorno = dialogo.Color;
                picCanvas.Invalidate();
            }
        }

        private void Vista_CheckedChanged(object sender, EventArgs e)
        {
            picCanvas.Invalidate();
        }

        // ===================== Resultados de la figura =====================

        private void MostrarResultados()
        {
            StringBuilder sb = new StringBuilder();
            double L = (double)nudLado.Value;
            List<Polygon2D> actuales = transformation.Apply(poligonosAnalisis);
            bool transformada = !transformation.Current.IsIdentity();

            if (cboFigura.SelectedIndex == 0)
            {
                Polygon2D hexagono = actuales[0];
                double sumaTriangulos = 0;
                for (int i = 1; i <= 6; i++) sumaTriangulos += actuales[i].Area();

                sb.AppendLine("HEXÁGONO REGULAR DE 6 COLORES");
                sb.AppendLine("Vértices: θi = θ0 + i·60°, R = L");
                sb.AppendLine();
                sb.AppendLine("Lado L                = " + F(L));
                sb.AppendLine("Centro                = " + transformation.Apply(centroFigura));
                sb.AppendLine("Triángulos generados  = 6");
                sb.AppendLine("Perímetro (6L)        = " + F(6 * L));
                sb.AppendLine("Área (3√3/2)L²        = " + F(3 * Math.Sqrt(3) / 2 * L * L));
                sb.AppendLine();
                sb.AppendLine("Perímetro calculado   = " + F(hexagono.Perimeter()));
                sb.AppendLine("Área por cordón       = " + F(hexagono.Area()));
                sb.AppendLine("Suma de 6 triángulos  = " + F(sumaTriangulos));
                sb.AppendLine();
                sb.AppendLine("Vértices:");
                for (int i = 0; i < 6; i++)
                    sb.AppendLine("  V" + i + " = " + hexagono.Vertices[i]);
            }
            else if (cboFigura.SelectedIndex == 1)
            {
                double s = (double)nudSeparacion.Value;
                double a = PolygonFactory.PentagonApothem(L);
                double suma = 0;

                sb.AppendLine("FLOR DE MARGARITA (5 PENTÁGONOS)");
                sb.AppendLine("Centros: αi = α0 + i·72°, R = s·2a");
                sb.AppendLine();
                sb.AppendLine("Cantidad de pentágonos = 5");
                sb.AppendLine("Vértices en total      = 25");
                sb.AppendLine("Lado L                 = " + F(L));
                sb.AppendLine("Apotema a              = " + F(a));
                sb.AppendLine("Separación s           = " + F(s));
                sb.AppendLine("Radio de distribución  = " + F(PolygonFactory.DaisyDistributionRadius(L, s)));
                sb.AppendLine();
                sb.AppendLine("Pétalo   Perímetro    Área");
                for (int i = 0; i < 5; i++)
                {
                    sb.AppendLine("  " + (i + 1) + "     " + F(actuales[i].Perimeter()) + "    " + F(actuales[i].Area()));
                    suma += actuales[i].Area();
                }
                sb.AppendLine("Perímetro teórico (5L)  = " + F(5 * L));
                sb.AppendLine("Área teórica (L²/4)√(25+10√5) = " + F(L * L / 4 * Math.Sqrt(25 + 10 * Math.Sqrt(5))));
                sb.AppendLine("Suma de áreas           = " + F(suma));
                sb.AppendLine();

                bool solapan = false;
                for (int i = 0; i < 5; i++)
                    if (GeometryOperations.PolygonsOverlap(actuales[i].Vertices, actuales[(i + 1) % 5].Vertices, 1e-7))
                        solapan = true;
                if (solapan)
                {
                    sb.AppendLine("Solapamiento: SÍ, los pétalos se solapan.");
                    sb.AppendLine("La suma de áreas NO es el área total");
                    sb.AppendLine("de la flor.");
                }
                else
                {
                    sb.AppendLine("Solapamiento: NO");
                    sb.AppendLine("(los pétalos se tocan o están separados).");
                }
                sb.AppendLine("El círculo del centro es decorativo.");
            }
            else
            {
                int n = (int)nudN.Value;
                int k = (int)nudK.Value;
                List<List<int>> recorridos = PolygonFactory.StarPaths(n, k);
                List<Vector2D> vertices = PolygonFactory.RegularVertices(centroFigura, L, n, (double)nudRotacion.Value);
                double perimetro = 0, areaAlgebraica = 0;
                foreach (Polygon2D p in actuales)
                {
                    perimetro += p.Perimeter();
                    areaAlgebraica += GeometryOperations.SignedArea(p.Vertices);
                }

                sb.AppendLine("POLÍGONO ESTRELLADO {" + n + "/" + k + "}");
                sb.AppendLine("Vértices: θi = θ0 + 360°·i/N, salto i → i + K");
                sb.AppendLine();
                if (k == 1) sb.AppendLine("Tipo: polígono regular (K = 1)");
                else if (recorridos.Count == 1) sb.AppendLine("Tipo: estrella");
                else sb.AppendLine("Tipo: " + recorridos.Count + " figuras (N y K no son coprimos)");
                sb.AppendLine("Número de vértices N   = " + n);
                sb.AppendLine("Radio R                = " + F(L));
                sb.AppendLine("Salto K                = " + k);
                sb.AppendLine("Componentes (mcd)      = " + PolygonFactory.Gcd(n, k));
                for (int i = 0; i < recorridos.Count; i++)
                    sb.AppendLine("Recorrido " + (i + 1) + ": " + string.Join(" → ", recorridos[i]) + " → " + recorridos[i][0]);
                sb.AppendLine("Longitud de segmento   = " + F(GeometryOperations.Distance(actuales[0].Vertices[0], actuales[0].Vertices[1])));
                sb.AppendLine("Perímetro del recorrido= " + F(perimetro));
                sb.AppendLine();
                sb.AppendLine("Área algebraica (cordón) = " + F(areaAlgebraica));
                sb.AppendLine("Nota: en una estrella las líneas se cruzan; el");
                sb.AppendLine("cordón cuenta algunas zonas más de una vez, por eso");
                sb.AppendLine("no es el área exacta de la región pintada.");
                sb.AppendLine();
                sb.AppendLine("Vértices:");
                for (int i = 0; i < n; i++)
                    sb.AppendLine("  V" + i + " = " + transformation.Apply(vertices[i]));
            }

            if (transformada)
            {
                sb.AppendLine();
                sb.AppendLine("La figura está transformada. Matriz acumulada M:");
                sb.Append(transformation.Current.ToString());
            }
            txtResultados.Text = sb.ToString();
        }

        // ===================== Dibujo =====================

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            renderer.SetCanvasSize(picCanvas.ClientSize.Width, picCanvas.ClientSize.Height);

            bool mostrarOriginal = !transformation.Current.IsIdentity() && chkOriginal.Checked;
            List<Polygon2D> actuales = transformation.Apply(figuraOriginal);

            // Si la figura no cabe con la escala normal se reduce la escala
            double maxX = 0, maxY = 0;
            List<Polygon2D> visibles = new List<Polygon2D>(actuales);
            if (mostrarOriginal) visibles.AddRange(figuraOriginal);
            foreach (Polygon2D p in visibles)
                foreach (Vector2D v in p.Vertices)
                {
                    maxX = Math.Max(maxX, Math.Abs(v.X));
                    maxY = Math.Max(maxY, Math.Abs(v.Y));
                }
            renderer.FitScale(maxX, maxY);
            lblEscala.Text = "Escala: " + renderer.Scale.ToString("0.#") + " px por unidad" +
                             (renderer.Scale < GeometryRenderer.DefaultScale ? " (reducida para que la figura quepa)" : "");

            if (chkCuadricula.Checked) renderer.DrawGrid(g);
            if (chkEjes.Checked) renderer.DrawAxes(g);

            // Figura original en gris si hay transformaciones
            if (mostrarOriginal)
                foreach (Polygon2D p in figuraOriginal)
                    renderer.DrawGhost(g, p);

            for (int i = 0; i < actuales.Count; i++)
                renderer.FillPolygon(g, actuales[i], ColorDeParte(i), colorContorno);

            foreach (Polygon2D p in transformation.Apply(poligonosAnalisis))
                renderer.DrawVertices(g, p);

            DibujarExtras(g);
        }

        private void DibujarExtras(Graphics g)
        {
            Vector2D origen = new Vector2D(0, 0);

            if (modoDibujo == "vectores")
            {
                renderer.DrawArrow(g, origen, puntoA, Color.Blue, "A");
                renderer.DrawArrow(g, origen, puntoB, Color.Red, "B");
            }
            else if (modoDibujo == "distancia")
            {
                renderer.DrawSegment(g, puntoA, puntoB, Color.Purple, true);
                renderer.DrawPoint(g, puntoA, Color.Blue, "A");
                renderer.DrawPoint(g, puntoB, Color.Blue, "B");
            }
            else if (modoDibujo == "orientacion")
            {
                renderer.DrawSegment(g, puntoA, puntoB, Color.DarkGreen, false);
                renderer.DrawSegment(g, puntoB, puntoC, Color.DarkGreen, false);
                renderer.DrawSegment(g, puntoC, puntoA, Color.DarkGreen, false);
                renderer.DrawPoint(g, puntoA, Color.Blue, "A");
                renderer.DrawPoint(g, puntoB, Color.Blue, "B");
                renderer.DrawPoint(g, puntoC, Color.Blue, "C");
            }
            else if (modoDibujo == "poligono")
            {
                renderer.DrawOutline(g, poligonoResaltado, Color.Teal, 4);
            }
            else if (modoDibujo == "pertenencia")
            {
                renderer.DrawOutline(g, poligonoResaltado, Color.Teal, 4);
                Color color = Color.Red;
                if (ubicacion == PointLocation.Inside) color = Color.Green;
                if (ubicacion == PointLocation.OnBorder) color = Color.DarkOrange;
                renderer.DrawPoint(g, puntoP, color, "P");
            }
            else if (modoDibujo == "proyeccion")
            {
                renderer.DrawSegment(g, proyeccion.A, proyeccion.B, Color.Black, false);
                renderer.DrawSegment(g, proyeccion.P, proyeccion.Q, Color.Red, true);
                renderer.DrawPoint(g, proyeccion.A, Color.Black, "A");
                renderer.DrawPoint(g, proyeccion.B, Color.Black, "B");
                renderer.DrawPoint(g, proyeccion.P, Color.Blue, "P");
                renderer.DrawPoint(g, proyeccion.Q, Color.Red, "Q");
            }
        }

        private void picCanvas_Resize(object sender, EventArgs e)
        {
            picCanvas.Invalidate();
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            Vector2D p = renderer.ToWorld(e.Location);
            lblCoordenadas.Text = "x = " + p.X.ToString("0.00") + ";  y = " + p.Y.ToString("0.00");
        }

        // Clic en el lienzo: coloca el punto P (en las pestañas Geometría o Proyección)
        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            Vector2D p = renderer.ToWorld(e.Location);
            string x = p.X.ToString("0.00", CultureInfo.InvariantCulture);
            string y = p.Y.ToString("0.00", CultureInfo.InvariantCulture);

            if (tabControl.SelectedTab == tabGeometria)
            {
                txtGPx.Text = x;
                txtGPy.Text = y;
                btnPertenencia_Click(sender, e);
            }
            else if (tabControl.SelectedTab == tabProyeccion)
            {
                txtPPx.Text = x;
                txtPPy.Text = y;
                btnProyectar_Click(sender, e);
            }
        }

        // ===================== Vectores =====================

        private void LeerVectores()
        {
            puntoA = LeerPunto(txtAx, txtAy, "A");
            puntoB = LeerPunto(txtBx, txtBy, "B");
            modoDibujo = "vectores";
            picCanvas.Invalidate();
        }

        private string TextoDireccion(Vector2D v)
        {
            try
            {
                return F(VectorOperations.DirectionDegrees(v)) + "°";
            }
            catch (ArgumentException)
            {
                return "indefinida (vector nulo)";
            }
        }

        private void btnMagA_Click(object sender, EventArgs e)
        {
            try
            {
                LeerVectores();
                txtVectores.AppendText("|A| = √(x² + y²) = " + F(VectorOperations.Magnitude(puntoA)) + "\r\n");
            }
            catch (Exception ex) { MostrarError(ex.Message); }
        }

        private void btnMagB_Click(object sender, EventArgs e)
        {
            try
            {
                LeerVectores();
                txtVectores.AppendText("|B| = √(x² + y²) = " + F(VectorOperations.Magnitude(puntoB)) + "\r\n");
            }
            catch (Exception ex) { MostrarError(ex.Message); }
        }

        private void btnDirA_Click(object sender, EventArgs e)
        {
            try
            {
                LeerVectores();
                txtVectores.AppendText("Dirección de A = atan2(y, x) = " + TextoDireccion(puntoA) + "\r\n");
            }
            catch (Exception ex) { MostrarError(ex.Message); }
        }

        private void btnDirB_Click(object sender, EventArgs e)
        {
            try
            {
                LeerVectores();
                txtVectores.AppendText("Dirección de B = atan2(y, x) = " + TextoDireccion(puntoB) + "\r\n");
            }
            catch (Exception ex) { MostrarError(ex.Message); }
        }

        private void btnProductoPunto_Click(object sender, EventArgs e)
        {
            try
            {
                LeerVectores();
                txtVectores.AppendText("A · B = ax·bx + ay·by = " + F(VectorOperations.Dot(puntoA, puntoB)) + "\r\n");
            }
            catch (Exception ex) { MostrarError(ex.Message); }
        }

        private void btnDeterminante_Click(object sender, EventArgs e)
        {
            try
            {
                LeerVectores();
                double det = VectorOperations.Determinant(puntoA, puntoB);
                string sentido = "A y B son paralelos";
                if (det > VectorOperations.Epsilon) sentido = "B está a la izquierda de A (antihorario)";
                if (det < -VectorOperations.Epsilon) sentido = "B está a la derecha de A (horario)";
                txtVectores.AppendText("det(A, B) = ax·by − ay·bx = " + F(det) + "\r\n   " + sentido + "\r\n");
            }
            catch (Exception ex) { MostrarError(ex.Message); }
        }

        private void btnTodoVectores_Click(object sender, EventArgs e)
        {
            try
            {
                LeerVectores();
                txtVectores.AppendText("A = " + puntoA + "   B = " + puntoB + "\r\n");
                btnMagA_Click(sender, e);
                btnMagB_Click(sender, e);
                btnDirA_Click(sender, e);
                btnDirB_Click(sender, e);
                btnProductoPunto_Click(sender, e);
                btnDeterminante_Click(sender, e);
                txtVectores.AppendText("--------------------------------\r\n");
            }
            catch (Exception ex) { MostrarError(ex.Message); }
        }

        // ===================== Geometría =====================

        private double LeerTolerancia()
        {
            double tolerancia = LeerNumero(txtTolerancia, "Tolerancia");
            if (tolerancia <= 0) throw new ArgumentException("La tolerancia debe ser mayor que cero.");
            return tolerancia;
        }

        private Polygon2D PoligonoSeleccionado()
        {
            // Se usa el polígono tal como se ve (con las transformaciones aplicadas)
            return poligonosAnalisis[cboPoligono.SelectedIndex].Transform(transformation.Current);
        }

        private void btnDistancia_Click(object sender, EventArgs e)
        {
            try
            {
                puntoA = LeerPunto(txtGAx, txtGAy, "A");
                puntoB = LeerPunto(txtGBx, txtGBy, "B");
                double d = GeometryOperations.Distance(puntoA, puntoB);
                txtGeometria.AppendText("Distancia entre A y B = " + F(d) + "\r\n");
                modoDibujo = "distancia";
                picCanvas.Invalidate();
            }
            catch (Exception ex) { MostrarError(ex.Message); }
        }

        private void btnOrientacion_Click(object sender, EventArgs e)
        {
            try
            {
                puntoA = LeerPunto(txtGAx, txtGAy, "A");
                puntoB = LeerPunto(txtGBx, txtGBy, "B");
                puntoC = LeerPunto(txtGCx, txtGCy, "C");
                double tolerancia = LeerTolerancia();
                double d = GeometryOperations.Orientation(puntoA, puntoB, puntoC);
                txtGeometria.AppendText("D = (Bx−Ax)(Cy−Ay) − (By−Ay)(Cx−Ax) = " + F(d) + "\r\n");
                txtGeometria.AppendText("Orientación: " + GeometryOperations.OrientationText(d, tolerancia) + "\r\n");
                modoDibujo = "orientacion";
                picCanvas.Invalidate();
            }
            catch (Exception ex) { MostrarError(ex.Message); }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            Polygon2D p = PoligonoSeleccionado();
            double areaConSigno = GeometryOperations.SignedArea(p.Vertices);
            txtGeometria.AppendText(p.Name + ":\r\n");
            txtGeometria.AppendText("  Área (cordón) = " + F(p.Area()) + "\r\n");
            txtGeometria.AppendText("  Perímetro     = " + F(p.Perimeter()) + "\r\n");
            txtGeometria.AppendText("  Vértices en sentido " + (areaConSigno > 0 ? "antihorario" : "horario") + "\r\n");
            poligonoResaltado = p;
            modoDibujo = "poligono";
            picCanvas.Invalidate();
        }

        private void btnPertenencia_Click(object sender, EventArgs e)
        {
            try
            {
                puntoP = LeerPunto(txtGPx, txtGPy, "P");
                double tolerancia = LeerTolerancia();
                Polygon2D p = PoligonoSeleccionado();
                ubicacion = GeometryOperations.PointInPolygon(puntoP, p.Vertices, tolerancia);

                string texto = "exterior";
                if (ubicacion == PointLocation.Inside) texto = "interior";
                if (ubicacion == PointLocation.OnBorder) texto = "sobre el borde";
                txtGeometria.AppendText("P = " + puntoP + " es " + texto + " de " + p.Name + "\r\n");

                poligonoResaltado = p;
                modoDibujo = "pertenencia";
                picCanvas.Invalidate();
            }
            catch (Exception ex) { MostrarError(ex.Message); }
        }

        // ===================== Proyección =====================

        private void btnProyectar_Click(object sender, EventArgs e)
        {
            try
            {
                Vector2D a = LeerPunto(txtPAx, txtPAy, "A");
                Vector2D b = LeerPunto(txtPBx, txtPBy, "B");
                Vector2D p = LeerPunto(txtPPx, txtPPy, "P");
                proyeccion = ProjectionOperations.Project(p, a, b);

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("A = " + a + "  B = " + b + "  P = " + p);
                if (proyeccion.Degenerate)
                {
                    sb.AppendLine("A y B coinciden (segmento degenerado), Q = A");
                }
                else
                {
                    sb.AppendLine("t = ((P−A)·(B−A)) / |B−A|², limitado a [0, 1]");
                    sb.AppendLine("t = " + F(proyeccion.T));
                    if (proyeccion.T == 0) sb.AppendLine("El punto más cercano es el extremo A");
                    else if (proyeccion.T == 1) sb.AppendLine("El punto más cercano es el extremo B");
                }
                sb.AppendLine("Q = A + t(B − A) = " + proyeccion.Q);
                sb.AppendLine("Distancia P-Q = " + F(proyeccion.Distance));
                sb.AppendLine("--------------------------------");
                txtProyeccion.AppendText(sb.ToString());

                modoDibujo = "proyeccion";
                picCanvas.Invalidate();
            }
            catch (Exception ex) { MostrarError(ex.Message); }
        }

        // ===================== Transformaciones =====================

        // Centro para rotar y escalar: el centro actual de la figura o el origen
        private Vector2D CentroTransformacion()
        {
            if (chkCentro.Checked) return transformation.Apply(centroFigura);
            return new Vector2D(0, 0);
        }

        private void btnTrasladar_Click(object sender, EventArgs e)
        {
            try
            {
                double tx = LeerNumero(txtTx, "Traslación X");
                double ty = LeerNumero(txtTy, "Traslación Y");
                Matrix3x3 anterior = transformation.Current;
                transformation.Translate(tx, ty);
                ActualizarTransformacion(anterior);
            }
            catch (Exception ex) { MostrarError(ex.Message); }
        }

        private void btnRotar_Click(object sender, EventArgs e)
        {
            try
            {
                double angulo = LeerNumero(txtAngulo, "Ángulo");
                Matrix3x3 anterior = transformation.Current;
                transformation.Rotate(angulo, CentroTransformacion());
                ActualizarTransformacion(anterior);
            }
            catch (Exception ex) { MostrarError(ex.Message); }
        }

        private void btnEscalar_Click(object sender, EventArgs e)
        {
            try
            {
                double sx = LeerNumero(txtSx, "Escala X");
                double sy = chkUniforme.Checked ? sx : LeerNumero(txtSy, "Escala Y");
                Matrix3x3 anterior = transformation.Current;
                transformation.Scale(sx, sy, CentroTransformacion());
                ActualizarTransformacion(anterior);
            }
            catch (Exception ex) { MostrarError(ex.Message); }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            transformation.Reset();
            ActualizarTransformacion(transformation.Current);
        }

        private void ActualizarTransformacion(Matrix3x3 anterior)
        {
            // Si la figura se sale demasiado del lienzo se deshace la operación
            foreach (Polygon2D p in transformation.Apply(figuraOriginal))
                foreach (Vector2D v in p.Vertices)
                    if (Math.Abs(v.X) > 50 || Math.Abs(v.Y) > 50)
                    {
                        transformation.Current = anterior;
                        MostrarError("La figura saldría del área de dibujo. Use valores más pequeños.");
                        return;
                    }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Última operación: " + transformation.LastOperation);
            sb.Append(transformation.LastMatrix.ToString());
            sb.AppendLine();
            sb.AppendLine("Matriz acumulada M (P' = M · P):");
            sb.Append(transformation.Current.ToString());
            txtTransformaciones.Text = sb.ToString();

            if (modoDibujo == "poligono" || modoDibujo == "pertenencia") modoDibujo = "";
            MostrarResultados();
            picCanvas.Invalidate();
        }

        private void chkUniforme_CheckedChanged(object sender, EventArgs e)
        {
            txtSy.Enabled = !chkUniforme.Checked;
            if (chkUniforme.Checked) txtSy.Text = txtSx.Text;
        }

        // ===================== Pruebas =====================

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            List<TestResult> resultados = GeometryTests.RunAll();
            dgvPruebas.DataSource = resultados;
            dgvPruebas.AutoResizeColumns();

            int aprobadas = 0;
            foreach (TestResult r in resultados)
                if (r.Estado == "Aprobado") aprobadas++;

            foreach (DataGridViewRow fila in dgvPruebas.Rows)
                fila.DefaultCellStyle.BackColor = fila.Cells["Estado"].Value.ToString() == "Aprobado"
                    ? Color.FromArgb(220, 255, 220) : Color.FromArgb(255, 220, 220);

            lblResumen.Text = aprobadas + " de " + resultados.Count + " pruebas aprobadas";
        }

        // ===================== Utilidades =====================

        // Lee un número de un TextBox. Acepta punto o coma decimal.
        private double LeerNumero(TextBox caja, string nombre)
        {
            double valor;
            string texto = caja.Text.Trim().Replace(',', '.');
            if (!double.TryParse(texto, NumberStyles.Float, CultureInfo.InvariantCulture, out valor)
                || double.IsNaN(valor) || double.IsInfinity(valor))
                throw new FormatException("El valor de \"" + nombre + "\" no es un número válido.");
            return valor;
        }

        private Vector2D LeerPunto(TextBox x, TextBox y, string nombre)
        {
            return new Vector2D(LeerNumero(x, nombre + ".x"), LeerNumero(y, nombre + ".y"));
        }

        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static string F(double valor)
        {
            return valor.ToString("0.0000");
        }
    }
}

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using GeoLab2D.Models;

namespace GeoLab2D.Rendering
{
    // Dibuja la geometría con GDI+ (Graphics, Pen, Brush, PointF).
    // Convierte coordenadas matemáticas (Y hacia arriba) a coordenadas de pantalla (Y hacia abajo):
    //   xPantalla = centroX + escala · x
    //   yPantalla = centroY − escala · y
    public class GeometryRenderer
    {
        public const float DefaultScale = 40;   // escala normal: píxeles por unidad
        public float Scale = DefaultScale;
        private float centerX;
        private float centerY;
        private int width;
        private int height;

        public void SetCanvasSize(int w, int h)
        {
            width = w;
            height = h;
            centerX = w / 2f;
            centerY = h / 2f;
        }

        // Se usa la escala normal; si la figura no cabe, se reduce la escala para que
        // se vea completa (el origen sigue en el centro del lienzo).
        // maxX y maxY son las coordenadas más alejadas del origen (en valor absoluto).
        public void FitScale(double maxX, double maxY)
        {
            const float margen = 20;
            float s = DefaultScale;
            if (maxX > 0) s = Math.Min(s, (float)((width / 2f - margen) / maxX));
            if (maxY > 0) s = Math.Min(s, (float)((height / 2f - margen) / maxY));
            Scale = Math.Max(s, 1);
        }

        // Distancia entre marcas de los ejes, según la escala
        private int PasoMarcas()
        {
            if (Scale >= 15) return 5;
            if (Scale >= 6) return 10;
            return 20;
        }

        public PointF ToScreen(Vector2D p)
        {
            return new PointF(centerX + (float)p.X * Scale, centerY - (float)p.Y * Scale);
        }

        public Vector2D ToWorld(Point p)
        {
            return new Vector2D((p.X - centerX) / Scale, (centerY - p.Y) / Scale);
        }

        private PointF[] ToScreen(Polygon2D poly)
        {
            PointF[] pts = new PointF[poly.Vertices.Count];
            for (int i = 0; i < pts.Length; i++)
                pts[i] = ToScreen(poly.Vertices[i]);
            return pts;
        }

        public void DrawGrid(Graphics g)
        {
            // Una línea por unidad; si la escala es pequeña, una cada 5 unidades
            float paso = Scale >= 15 ? Scale : Scale * 5;
            using (Pen pen = new Pen(Color.FromArgb(230, 230, 235)))
            {
                for (float x = centerX % paso; x < width; x += paso)
                    g.DrawLine(pen, x, 0, x, height);
                for (float y = centerY % paso; y < height; y += paso)
                    g.DrawLine(pen, 0, y, width, y);
            }
        }

        public void DrawAxes(Graphics g)
        {
            using (Pen pen = new Pen(Color.Gray, 1.5f))
            using (Font font = new Font("Segoe UI", 8))
            {
                g.DrawLine(pen, 0, centerY, width, centerY);
                g.DrawLine(pen, centerX, 0, centerX, height);
                g.DrawString("X", font, Brushes.Gray, width - 15, centerY + 2);
                g.DrawString("Y", font, Brushes.Gray, centerX + 4, 2);

                // Marcas cada 5, 10 o 20 unidades hasta el borde del lienzo
                int pasoMarcas = PasoMarcas();
                int limite = (int)(Math.Max(width, height) / 2f / Scale) + pasoMarcas;
                for (int i = -(limite / pasoMarcas) * pasoMarcas; i <= limite; i += pasoMarcas)
                {
                    if (i == 0) continue;
                    PointF px = ToScreen(new Vector2D(i, 0));
                    PointF py = ToScreen(new Vector2D(0, i));
                    if (px.X > 10 && px.X < width - 25)
                        g.DrawString(i.ToString(), font, Brushes.Gray, px.X - 6, px.Y + 3);
                    if (py.Y > 20 && py.Y < height - 10)
                        g.DrawString(i.ToString(), font, Brushes.Gray, py.X + 4, py.Y - 7);
                }
            }
        }

        public void FillPolygon(Graphics g, Polygon2D poly, Color fill, Color border)
        {
            PointF[] pts = ToScreen(poly);
            using (SolidBrush brush = new SolidBrush(fill))
            using (Pen pen = new Pen(border, 2))
            {
                g.FillPolygon(brush, pts);
                g.DrawPolygon(pen, pts);
            }
        }

        // Figura original en gris punteado (cuando hay transformaciones)
        public void DrawGhost(Graphics g, Polygon2D poly)
        {
            using (Pen pen = new Pen(Color.Gray, 1))
            {
                pen.DashStyle = DashStyle.Dash;
                g.DrawPolygon(pen, ToScreen(poly));
            }
        }

        public void DrawOutline(Graphics g, Polygon2D poly, Color color, float width)
        {
            using (Pen pen = new Pen(color, width))
                g.DrawPolygon(pen, ToScreen(poly));
        }

        public void DrawVertices(Graphics g, Polygon2D poly)
        {
            foreach (Vector2D v in poly.Vertices)
            {
                PointF p = ToScreen(v);
                g.FillEllipse(Brushes.White, p.X - 3, p.Y - 3, 6, 6);
                g.DrawEllipse(Pens.Black, p.X - 3, p.Y - 3, 6, 6);
            }
        }

        public void DrawPoint(Graphics g, Vector2D v, Color color, string label)
        {
            PointF p = ToScreen(v);
            using (SolidBrush brush = new SolidBrush(color))
            using (Font font = new Font("Segoe UI", 9, FontStyle.Bold))
            {
                g.FillEllipse(brush, p.X - 5, p.Y - 5, 10, 10);
                g.DrawString(label, font, brush, p.X + 6, p.Y - 18);
            }
        }

        public void DrawSegment(Graphics g, Vector2D a, Vector2D b, Color color, bool dashed)
        {
            using (Pen pen = new Pen(color, 2))
            {
                if (dashed) pen.DashStyle = DashStyle.Dash;
                g.DrawLine(pen, ToScreen(a), ToScreen(b));
            }
        }

        public void DrawArrow(Graphics g, Vector2D from, Vector2D to, Color color, string label)
        {
            using (Pen pen = new Pen(color, 3))
            using (SolidBrush brush = new SolidBrush(color))
            using (Font font = new Font("Segoe UI", 9, FontStyle.Bold))
            using (AdjustableArrowCap flecha = new AdjustableArrowCap(4, 5))
            {
                pen.CustomEndCap = flecha;
                PointF end = ToScreen(to);
                g.DrawLine(pen, ToScreen(from), end);
                g.DrawString(label, font, brush, end.X + 5, end.Y - 18);
            }
        }
    }
}

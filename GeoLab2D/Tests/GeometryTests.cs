using System;
using System.Collections.Generic;
using GeoLab2D.Geometry;
using GeoLab2D.Models;
using GeoLab2D.Transformations;

namespace GeoLab2D.Tests
{
    // Una fila de la tabla de pruebas
    public class TestResult
    {
        public string Prueba { get; set; }
        public string Entradas { get; set; }
        public string Esperado { get; set; }
        public string Obtenido { get; set; }
        public string Tolerancia { get; set; }
        public string Estado { get; set; }
    }

    // Plan de pruebas matemáticas. Se ejecuta desde la pestaña "Pruebas".
    public static class GeometryTests
    {
        private const double Tol = 0.000001;
        private static List<TestResult> results;

        public static List<TestResult> RunAll()
        {
            results = new List<TestResult>();

            // 1. Magnitud
            double mag = VectorOperations.Magnitude(new Vector2D(3, 4));
            Add("1. Magnitud vectorial", "A = (3, 4)", "|A| = 5", "|A| = " + mag, Near(mag, 5));

            // 2. Producto punto
            double dot = VectorOperations.Dot(new Vector2D(1, 2), new Vector2D(3, 4));
            Add("2. Producto punto", "A = (1, 2), B = (3, 4)", "11", dot.ToString(), Near(dot, 11));

            // 3. Determinante
            double det = VectorOperations.Determinant(new Vector2D(1, 0), new Vector2D(0, 1));
            Add("3. Determinante", "A = (1, 0), B = (0, 1)", "1", det.ToString(), Near(det, 1));

            // 4. Distancia
            double d = GeometryOperations.Distance(new Vector2D(0, 0), new Vector2D(3, 4));
            Add("4. Distancia", "A = (0, 0), B = (3, 4)", "5", d.ToString(), Near(d, 5));

            // 5. Hexágono de lado 2
            Polygon2D hex = PolygonFactory.CreateHexagon(new Vector2D(0, 0), 2, 0);
            double hexA = hex.Area(), hexP = hex.Perimeter();
            Add("5. Área del hexágono", "L = 2", "P = 12, A = 6√3 ≈ 10.3923",
                "P = " + hexP.ToString("0.0000") + ", A = " + hexA.ToString("0.0000"),
                Near(hexP, 12) && Near(hexA, 6 * Math.Sqrt(3)));

            // 6. Pentágono de lado 2: A = (L²/4)·√(25 + 10√5)
            double radio = PolygonFactory.PentagonRadius(2);
            Polygon2D pent = new Polygon2D("Pentágono", PolygonFactory.RegularVertices(new Vector2D(0, 0), radio, 5, 90));
            double pentA = pent.Area(), pentP = pent.Perimeter();
            double formula = (2.0 * 2.0 / 4.0) * Math.Sqrt(25 + 10 * Math.Sqrt(5));
            Add("6. Área del pentágono", "L = 2", "P = 10, A ≈ 6.8819",
                "P = " + pentP.ToString("0.0000") + ", A = " + pentA.ToString("0.0000"),
                Near(pentP, 10) && Near(pentA, formula));

            // 7. Traslación
            Vector2D t = Matrix3x3.Translation(5, -1).Transform(new Vector2D(2, 3));
            Add("7. Traslación", "P = (2, 3), T = (5, -1)", "(7; 2)", t.ToString(), Near(t.X, 7) && Near(t.Y, 2));

            // 8. Rotación
            Vector2D r = Matrix3x3.Rotation(90).Transform(new Vector2D(1, 0));
            Add("8. Rotación", "P = (1, 0), θ = 90°", "(0; 1)", r.ToString(), Near(r.X, 0) && Near(r.Y, 1));

            // 9. Escalamiento
            Vector2D s = Matrix3x3.Scaling(2, 3).Transform(new Vector2D(2, 3));
            Add("9. Escalamiento", "P = (2, 3), sx = 2, sy = 3", "(4; 9)", s.ToString(), Near(s.X, 4) && Near(s.Y, 9));

            // 10. Proyección
            ProjectionResult pr = ProjectionOperations.Project(new Vector2D(2, 3), new Vector2D(0, 0), new Vector2D(4, 0));
            Add("10. Proyección", "A = (0, 0), B = (4, 0), P = (2, 3)", "Q = (2; 0), d = 3",
                "Q = " + pr.Q + ", d = " + pr.Distance, Near(pr.Q.X, 2) && Near(pr.Q.Y, 0) && Near(pr.Distance, 3));

            // 11. Punto interior, exterior y en el borde
            List<Vector2D> cuadrado = new List<Vector2D>
            {
                new Vector2D(0, 0), new Vector2D(4, 0), new Vector2D(4, 4), new Vector2D(0, 4)
            };
            PointLocation l1 = GeometryOperations.PointInPolygon(new Vector2D(2, 2), cuadrado, VectorOperations.Epsilon);
            PointLocation l2 = GeometryOperations.PointInPolygon(new Vector2D(5, 2), cuadrado, VectorOperations.Epsilon);
            PointLocation l3 = GeometryOperations.PointInPolygon(new Vector2D(4, 2), cuadrado, VectorOperations.Epsilon);
            Add("11. Pertenencia a un polígono", "Cuadrado (0,0)-(4,4); P = (2,2), (5,2), (4,2)",
                "Inside, Outside, OnBorder", l1 + ", " + l2 + ", " + l3,
                l1 == PointLocation.Inside && l2 == PointLocation.Outside && l3 == PointLocation.OnBorder);

            // 12. Segmento degenerado (A = B)
            ProjectionResult deg = ProjectionOperations.Project(new Vector2D(4, 5), new Vector2D(1, 1), new Vector2D(1, 1));
            Add("12. Segmento degenerado", "A = B = (1, 1), P = (4, 5)", "Q = A, d = 5, sin división entre cero",
                "Q = " + deg.Q + ", d = " + deg.Distance, deg.Degenerate && Near(deg.Distance, 5));

            // 13. Estrella {5/2}
            List<List<int>> caminos = PolygonFactory.StarPaths(5, 2);
            string recorrido = string.Join("→", caminos[0]);
            bool cerrada = (caminos[0][4] + 2) % 5 == caminos[0][0];
            Add("13. Estrella de 5 vértices", "N = 5, K = 2", "1 recorrido cerrado con los 5 vértices",
                caminos.Count + " recorrido: " + recorrido + "→" + caminos[0][0],
                caminos.Count == 1 && caminos[0].Count == 5 && cerrada);

            // 14. Restaurar la figura original
            List<Polygon2D> originales = PolygonFactory.CreateHexagonTriangles(new Vector2D(1, 1), 3, 0);
            Transformation2D tr = new Transformation2D();
            for (int i = 0; i < 20; i++)
            {
                tr.Rotate(37, new Vector2D(1, 1));
                tr.Scale(1.1, 0.9, new Vector2D(1, 1));
                tr.Translate(0.5, -0.2);
            }
            tr.Reset();
            bool iguales = true;
            List<Polygon2D> restaurados = tr.Apply(originales);
            for (int i = 0; i < originales.Count; i++)
                for (int j = 0; j < originales[i].Vertices.Count; j++)
                    if (!originales[i].Vertices[j].Equals(restaurados[i].Vertices[j])) iguales = false;
            Add("14. Restauración", "Hexágono, 60 transformaciones y Restaurar", "Coordenadas originales",
                iguales ? "Coordenadas idénticas" : "Diferentes", iguales);

            // 15. Orientación de tres puntos
            double o1 = GeometryOperations.Orientation(new Vector2D(0, 0), new Vector2D(1, 0), new Vector2D(0, 1));
            double o2 = GeometryOperations.Orientation(new Vector2D(0, 0), new Vector2D(0, 1), new Vector2D(1, 0));
            double o3 = GeometryOperations.Orientation(new Vector2D(0, 0), new Vector2D(1, 1), new Vector2D(2, 2));
            string texto = GeometryOperations.OrientationText(o1, VectorOperations.Epsilon) + ", " +
                           GeometryOperations.OrientationText(o2, VectorOperations.Epsilon) + ", " +
                           GeometryOperations.OrientationText(o3, VectorOperations.Epsilon);
            Add("15. Orientación", "(0,0),(1,0),(0,1) | (0,0),(0,1),(1,0) | (0,0),(1,1),(2,2)",
                "Antihoraria, Horaria, Colineales", texto, texto == "Antihoraria, Horaria, Colineales");

            // 16. Estrella {6/2}: dos triángulos
            List<List<int>> c62 = PolygonFactory.StarPaths(6, 2);
            Add("16. Estrella {6/2}", "N = 6, K = 2", "2 recorridos de 3 vértices",
                c62.Count + " recorridos", c62.Count == 2 && c62[0].Count == 3);

            // 17. Margarita: solapamiento entre pétalos vecinos
            List<Polygon2D> flor1 = PolygonFactory.CreateDaisy(new Vector2D(0, 0), 2, 90, 1.0);
            List<Polygon2D> flor2 = PolygonFactory.CreateDaisy(new Vector2D(0, 0), 2, 90, 0.8);
            bool sol1 = GeometryOperations.PolygonsOverlap(flor1[0].Vertices, flor1[1].Vertices, 1e-7);
            bool sol2 = GeometryOperations.PolygonsOverlap(flor2[0].Vertices, flor2[1].Vertices, 1e-7);
            Add("17. Margarita: solapamiento", "L = 2; separación 1.0 y 0.8", "1.0: no se solapan; 0.8: sí",
                "1.0: " + (sol1 ? "sí" : "no") + "; 0.8: " + (sol2 ? "sí" : "no"), !sol1 && sol2);

            // 18. Vector nulo
            bool error = false;
            try { VectorOperations.DirectionDegrees(new Vector2D(0, 0)); }
            catch (ArgumentException) { error = true; }
            Add("18. Dirección del vector nulo", "V = (0, 0)", "Error controlado (sin dirección)",
                error ? "Error controlado" : "Sin error", error);

            return results;
        }

        private static bool Near(double a, double b)
        {
            return Math.Abs(a - b) <= Tol;
        }

        private static void Add(string name, string inputs, string expected, string obtained, bool ok)
        {
            results.Add(new TestResult
            {
                Prueba = name,
                Entradas = inputs,
                Esperado = expected,
                Obtenido = obtained,
                Tolerancia = "0.000001",
                Estado = ok ? "Aprobado" : "Fallido"
            });
        }
    }
}

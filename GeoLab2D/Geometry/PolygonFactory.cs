using System;
using System.Collections.Generic;
using GeoLab2D.Models;

namespace GeoLab2D.Geometry
{
    // Construye las figuras con fórmulas (seno y coseno). No hay coordenadas fijas.
    public static class PolygonFactory
    {
        // n puntos sobre una circunferencia:
        // θi = θ0 + 2πi/n,  xi = cx + r·cos(θi),  yi = cy + r·sin(θi)
        public static List<Vector2D> RegularVertices(Vector2D center, double radius, int n, double startDegrees)
        {
            if (radius <= 0) throw new ArgumentException("El radio o el lado debe ser mayor que cero.");
            if (n < 3) throw new ArgumentException("Se necesitan al menos 3 vértices.");

            List<Vector2D> vertices = new List<Vector2D>();
            for (int i = 0; i < n; i++)
            {
                double theta = (startDegrees * Math.PI / 180.0) + 2 * Math.PI * i / n;
                vertices.Add(new Vector2D(center.X + radius * Math.Cos(theta),
                                          center.Y + radius * Math.Sin(theta)));
            }
            return vertices;
        }

        // ---------------- Figura 1: hexágono de 6 colores ----------------

        // En un hexágono regular el radio es igual al lado (R = L)
        public static Polygon2D CreateHexagon(Vector2D center, double side, double rotation)
        {
            return new Polygon2D("Hexágono", RegularVertices(center, side, 6, rotation));
        }

        // Seis triángulos: (centro, vértice i, vértice i+1)
        public static List<Polygon2D> CreateHexagonTriangles(Vector2D center, double side, double rotation)
        {
            List<Vector2D> v = RegularVertices(center, side, 6, rotation);
            List<Polygon2D> triangles = new List<Polygon2D>();
            for (int i = 0; i < 6; i++)
            {
                List<Vector2D> t = new List<Vector2D> { center, v[i], v[(i + 1) % 6] };
                triangles.Add(new Polygon2D("Triángulo " + (i + 1), t));
            }
            return triangles;
        }

        // ---------------- Figura 2: margarita de 5 pentágonos ----------------

        // Apotema del pentágono: a = L / (2·tan 36°)
        public static double PentagonApothem(double side)
        {
            return side / (2 * Math.Tan(Math.PI / 5));
        }

        // Radio del pentágono: R = L / (2·sin 36°)
        public static double PentagonRadius(double side)
        {
            return side / (2 * Math.Sin(Math.PI / 5));
        }

        // Distancia del centro de la flor al centro de cada pétalo: R = separación · 2a.
        // Con separación = 1 los pétalos se tocan sólo en un vértice.
        public static double DaisyDistributionRadius(double side, double separation)
        {
            return separation * 2 * PentagonApothem(side);
        }

        // Centros: αi = α0 + i·72°, pi = C + R(cos αi, sin αi).
        // Cada pentágono tiene un vértice apuntando hacia afuera (ángulo inicial = αi).
        public static List<Polygon2D> CreateDaisy(Vector2D center, double side, double rotation, double separation)
        {
            if (side <= 0) throw new ArgumentException("El lado debe ser mayor que cero.");
            if (separation <= 0) throw new ArgumentException("La separación debe ser mayor que cero.");

            double R = DaisyDistributionRadius(side, separation);
            List<Polygon2D> petals = new List<Polygon2D>();
            for (int i = 0; i < 5; i++)
            {
                double alpha = rotation + i * 72;
                double rad = alpha * Math.PI / 180.0;
                Vector2D petalCenter = new Vector2D(center.X + R * Math.Cos(rad), center.Y + R * Math.Sin(rad));
                petals.Add(new Polygon2D("Pétalo " + (i + 1), RegularVertices(petalCenter, PentagonRadius(side), 5, alpha)));
            }
            return petals;
        }

        // Centro de la flor: un círculo (aproximado con 40 lados) de otro color
        public static Polygon2D CreateDaisyCenter(Vector2D center, double side, double separation)
        {
            double a = PentagonApothem(side);
            double R = DaisyDistributionRadius(side, separation);
            double radius = Math.Max(0.4 * a, 0.75 * (R - a));
            return new Polygon2D("Centro", RegularVertices(center, radius, 40, 0));
        }

        // ---------------- Figura 3: polígonos estrellados ----------------

        // Recorre los índices saltando de K en K: i -> (i + K) mod N.
        // Si N y K no son coprimos se obtienen varios recorridos (componentes).
        public static List<List<int>> StarPaths(int n, int k)
        {
            if (n < 3) throw new ArgumentException("N debe ser al menos 3.");
            if (k < 1 || 2 * k >= n) throw new ArgumentException("El salto K debe cumplir 1 ≤ K < N/2.");

            bool[] visitado = new bool[n];
            List<List<int>> paths = new List<List<int>>();
            for (int inicio = 0; inicio < n; inicio++)
            {
                if (visitado[inicio]) continue;
                List<int> path = new List<int>();
                int i = inicio;
                do
                {
                    visitado[i] = true;
                    path.Add(i);
                    i = (i + k) % n;
                } while (i != inicio);
                paths.Add(path);
            }
            return paths;
        }

        public static List<Polygon2D> CreateStar(Vector2D center, double radius, int n, int k, double startDegrees)
        {
            List<Vector2D> v = RegularVertices(center, radius, n, startDegrees);
            List<List<int>> paths = StarPaths(n, k);

            List<Polygon2D> stars = new List<Polygon2D>();
            for (int c = 0; c < paths.Count; c++)
            {
                List<Vector2D> puntos = new List<Vector2D>();
                foreach (int index in paths[c])
                    puntos.Add(v[index]);
                stars.Add(new Polygon2D(paths.Count == 1 ? "Estrella" : "Estrella " + (c + 1), puntos));
            }
            return stars;
        }

        // Máximo común divisor (cantidad de componentes de la estrella)
        public static int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int t = a % b;
                a = b;
                b = t;
            }
            return a;
        }
    }
}

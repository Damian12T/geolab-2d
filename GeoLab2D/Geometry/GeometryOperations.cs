using System;
using System.Collections.Generic;
using GeoLab2D.Models;

namespace GeoLab2D.Geometry
{
    public static class GeometryOperations
    {
        // d = raíz((x2 − x1)² + (y2 − y1)²)
        public static double Distance(Vector2D a, Vector2D b)
        {
            return (b - a).Magnitude();
        }

        // Método del cordón (shoelace) con signo:
        // A = 1/2 · Σ (xi·yi+1 − yi·xi+1). Es positiva si los vértices van en sentido antihorario.
        public static double SignedArea(List<Vector2D> v)
        {
            double sum = 0;
            for (int i = 0; i < v.Count; i++)
            {
                Vector2D actual = v[i];
                Vector2D siguiente = v[(i + 1) % v.Count];   // el último se une con el primero
                sum += actual.X * siguiente.Y - actual.Y * siguiente.X;
            }
            return sum / 2.0;
        }

        public static double PolygonArea(List<Vector2D> v)
        {
            return Math.Abs(SignedArea(v));
        }

        // Suma de las distancias entre vértices consecutivos, incluyendo el cierre
        public static double Perimeter(List<Vector2D> v)
        {
            double sum = 0;
            for (int i = 0; i < v.Count; i++)
                sum += Distance(v[i], v[(i + 1) % v.Count]);
            return sum;
        }

        // D = (Bx − Ax)(Cy − Ay) − (By − Ay)(Cx − Ax)
        public static double Orientation(Vector2D a, Vector2D b, Vector2D c)
        {
            return (b.X - a.X) * (c.Y - a.Y) - (b.Y - a.Y) * (c.X - a.X);
        }

        public static string OrientationText(double d, double epsilon)
        {
            if (d > epsilon) return "Antihoraria";
            if (d < -epsilon) return "Horaria";
            return "Colineales";
        }

        // Pertenencia de un punto a un polígono:
        // 1) si está a una distancia menor que epsilon de algún lado, está en el borde;
        // 2) si no, se lanza un rayo horizontal hacia la derecha y se cuentan los cruces
        //    (ray casting). Número impar de cruces = interior.
        public static PointLocation PointInPolygon(Vector2D p, List<Vector2D> poly, double epsilon)
        {
            int n = poly.Count;
            for (int i = 0; i < n; i++)
            {
                ProjectionResult r = ProjectionOperations.Project(p, poly[i], poly[(i + 1) % n]);
                if (r.Distance <= epsilon)
                    return PointLocation.OnBorder;
            }

            bool inside = false;
            for (int i = 0, j = n - 1; i < n; j = i++)
            {
                Vector2D a = poly[i];
                Vector2D b = poly[j];
                // Regla semiabierta: así un vértice que toca el rayo se cuenta una sola vez
                if ((a.Y > p.Y) != (b.Y > p.Y))
                {
                    double xCruce = a.X + (p.Y - a.Y) * (b.X - a.X) / (b.Y - a.Y);
                    if (p.X < xCruce)
                        inside = !inside;
                }
            }
            return inside ? PointLocation.Inside : PointLocation.Outside;
        }

        // Dos segmentos se cruzan si cada uno deja los extremos del otro en lados opuestos
        // (se usa la misma fórmula de orientación). Si sólo se tocan en un punto no cuenta.
        public static bool SegmentsCross(Vector2D p1, Vector2D p2, Vector2D q1, Vector2D q2, double epsilon)
        {
            double d1 = Orientation(p1, p2, q1);
            double d2 = Orientation(p1, p2, q2);
            double d3 = Orientation(q1, q2, p1);
            double d4 = Orientation(q1, q2, p2);
            bool opuestos1 = (d1 > epsilon && d2 < -epsilon) || (d1 < -epsilon && d2 > epsilon);
            bool opuestos2 = (d3 > epsilon && d4 < -epsilon) || (d3 < -epsilon && d4 > epsilon);
            return opuestos1 && opuestos2;
        }

        // Dos polígonos convexos se solapan si algún lado de uno cruza algún lado del otro
        public static bool PolygonsOverlap(List<Vector2D> a, List<Vector2D> b, double epsilon)
        {
            for (int i = 0; i < a.Count; i++)
                for (int j = 0; j < b.Count; j++)
                    if (SegmentsCross(a[i], a[(i + 1) % a.Count], b[j], b[(j + 1) % b.Count], epsilon))
                        return true;
            return false;
        }
    }
}

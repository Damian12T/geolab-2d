using System;
using GeoLab2D.Models;

namespace GeoLab2D.Geometry
{
    public static class ProjectionOperations
    {
        // Punto más cercano a P sobre el segmento AB:
        // t = ((P − A)·(B − A)) / |B − A|², se limita t a [0, 1] y Q = A + t(B − A)
        public static ProjectionResult Project(Vector2D p, Vector2D a, Vector2D b)
        {
            ProjectionResult r = new ProjectionResult();
            r.A = a;
            r.B = b;
            r.P = p;

            Vector2D ab = b - a;
            double largo2 = VectorOperations.Dot(ab, ab);

            // Segmento degenerado (A = B): se evita dividir entre cero y Q = A
            if (largo2 < 1e-12)
            {
                r.Degenerate = true;
                r.T = 0;
                r.Q = a;
            }
            else
            {
                double t = VectorOperations.Dot(p - a, ab) / largo2;
                r.T = Math.Max(0, Math.Min(1, t));
                r.Q = a + r.T * ab;
            }

            r.Distance = GeometryOperations.Distance(p, r.Q);
            return r;
        }
    }
}

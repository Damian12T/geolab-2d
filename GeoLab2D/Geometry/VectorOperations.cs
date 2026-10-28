using System;
using GeoLab2D.Models;

namespace GeoLab2D.Geometry
{
    public static class VectorOperations
    {
        // Tolerancia para comparar números decimales con cero
        public const double Epsilon = 1e-9;

        // |V| = raíz(x² + y²)
        public static double Magnitude(Vector2D v)
        {
            return v.Magnitude();
        }

        public static bool IsZero(Vector2D v)
        {
            return v.Magnitude() < Epsilon;
        }

        // Dirección con atan2(y, x), convertida a grados entre 0° y 360°.
        // El vector nulo no tiene dirección, por eso se lanza un error.
        public static double DirectionDegrees(Vector2D v)
        {
            if (IsZero(v))
                throw new ArgumentException("El vector nulo (0, 0) no tiene dirección definida.");

            double degrees = Math.Atan2(v.Y, v.X) * 180.0 / Math.PI;
            if (degrees < 0) degrees += 360;
            return degrees;
        }

        // A · B = ax·bx + ay·by
        public static double Dot(Vector2D a, Vector2D b)
        {
            return a.X * b.X + a.Y * b.Y;
        }

        // det(A, B) = ax·by − ay·bx
        public static double Determinant(Vector2D a, Vector2D b)
        {
            return a.X * b.Y - a.Y * b.X;
        }
    }
}

using System;

namespace GeoLab2D.Models
{
    // Representa un vector o un punto en 2D.
    // Se usan coordenadas matemáticas: el eje Y crece hacia arriba.
    public struct Vector2D
    {
        public double X;
        public double Y;

        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        // |V| = raíz(x² + y²)
        public double Magnitude()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public static Vector2D operator +(Vector2D a, Vector2D b)
        {
            return new Vector2D(a.X + b.X, a.Y + b.Y);
        }

        public static Vector2D operator -(Vector2D a, Vector2D b)
        {
            return new Vector2D(a.X - b.X, a.Y - b.Y);
        }

        public static Vector2D operator *(double k, Vector2D v)
        {
            return new Vector2D(k * v.X, k * v.Y);
        }

        public override string ToString()
        {
            return "(" + X.ToString("0.####") + "; " + Y.ToString("0.####") + ")";
        }
    }
}

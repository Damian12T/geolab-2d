using System;
using System.Collections.Generic;
using GeoLab2D.Models;

namespace GeoLab2D.Transformations
{
    // Guarda la transformación acumulada de la figura en una sola matriz.
    // La figura original nunca se modifica: siempre se calcula P' = M · P desde los
    // vértices originales. Por eso al restaurar (M = I) se recuperan exactamente.
    public class Transformation2D
    {
        public Matrix3x3 Current = Matrix3x3.Identity();
        public Matrix3x3 LastMatrix = Matrix3x3.Identity();
        public string LastOperation = "Ninguna";

        // La nueva operación se aplica después de las anteriores: M = Op · M
        private void Add(Matrix3x3 op, string name)
        {
            Current = op * Current;
            LastMatrix = op;
            LastOperation = name;
        }

        public void Translate(double tx, double ty)
        {
            Add(Matrix3x3.Translation(tx, ty), "Traslación (" + tx + ", " + ty + ")");
        }

        // Rotación alrededor de un centro C: M = T(C) · R(θ) · T(−C)
        public void Rotate(double degrees, Vector2D c)
        {
            Matrix3x3 m = Matrix3x3.Translation(c.X, c.Y) * Matrix3x3.Rotation(degrees) * Matrix3x3.Translation(-c.X, -c.Y);
            Add(m, "Rotación " + degrees + "° alrededor de " + c);
        }

        // Escalamiento respecto de un centro C: M = T(C) · S(sx, sy) · T(−C)
        public void Scale(double sx, double sy, Vector2D c)
        {
            if (Math.Abs(sx) < 0.001 || Math.Abs(sy) < 0.001)
                throw new ArgumentException("Los factores de escala deben ser distintos de cero.");
            Matrix3x3 m = Matrix3x3.Translation(c.X, c.Y) * Matrix3x3.Scaling(sx, sy) * Matrix3x3.Translation(-c.X, -c.Y);
            Add(m, "Escalamiento (" + sx + ", " + sy + ") respecto de " + c);
        }

        public void Reset()
        {
            Current = Matrix3x3.Identity();
            LastMatrix = Matrix3x3.Identity();
            LastOperation = "Restaurar (M = I)";
        }

        public Vector2D Apply(Vector2D p)
        {
            return Current.Transform(p);
        }

        public List<Polygon2D> Apply(List<Polygon2D> originals)
        {
            List<Polygon2D> result = new List<Polygon2D>();
            foreach (Polygon2D p in originals)
                result.Add(p.Transform(Current));
            return result;
        }
    }
}

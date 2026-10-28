using System;

namespace GeoLab2D.Models
{
    // Matriz homogénea 3x3 para transformaciones 2D.
    // Los puntos se usan como columna P = [x, y, 1] y se transforman con P' = M · P.
    // En un producto A · B primero se aplica B y después A.
    public class Matrix3x3
    {
        public double[,] M = new double[3, 3];

        public static Matrix3x3 Identity()
        {
            Matrix3x3 r = new Matrix3x3();
            r.M[0, 0] = 1;
            r.M[1, 1] = 1;
            r.M[2, 2] = 1;
            return r;
        }

        // T = [1 0 tx; 0 1 ty; 0 0 1]
        public static Matrix3x3 Translation(double tx, double ty)
        {
            Matrix3x3 r = Identity();
            r.M[0, 2] = tx;
            r.M[1, 2] = ty;
            return r;
        }

        // R = [cos -sin 0; sin cos 0; 0 0 1]  (ángulo positivo = antihorario)
        public static Matrix3x3 Rotation(double degrees)
        {
            double rad = degrees * Math.PI / 180.0;
            Matrix3x3 r = Identity();
            r.M[0, 0] = Math.Cos(rad);
            r.M[0, 1] = -Math.Sin(rad);
            r.M[1, 0] = Math.Sin(rad);
            r.M[1, 1] = Math.Cos(rad);
            return r;
        }

        // S = [sx 0 0; 0 sy 0; 0 0 1]
        public static Matrix3x3 Scaling(double sx, double sy)
        {
            Matrix3x3 r = Identity();
            r.M[0, 0] = sx;
            r.M[1, 1] = sy;
            return r;
        }

        // Producto de matrices (fila por columna)
        public static Matrix3x3 operator *(Matrix3x3 a, Matrix3x3 b)
        {
            Matrix3x3 r = new Matrix3x3();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    for (int k = 0; k < 3; k++)
                        r.M[i, j] += a.M[i, k] * b.M[k, j];
            return r;
        }

        // P' = M · [x, y, 1]
        public Vector2D Transform(Vector2D p)
        {
            double x = M[0, 0] * p.X + M[0, 1] * p.Y + M[0, 2];
            double y = M[1, 0] * p.X + M[1, 1] * p.Y + M[1, 2];
            return new Vector2D(x, y);
        }

        public bool IsIdentity()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    double expected = (i == j) ? 1 : 0;
                    if (Math.Abs(M[i, j] - expected) > 1e-12) return false;
                }
            return true;
        }

        public override string ToString()
        {
            string text = "";
            for (int i = 0; i < 3; i++)
            {
                text += "[ ";
                for (int j = 0; j < 3; j++)
                    text += M[i, j].ToString("0.000").PadLeft(8) + " ";
                text += "]\r\n";
            }
            return text;
        }
    }
}

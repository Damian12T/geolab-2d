using System.Collections.Generic;
using GeoLab2D.Geometry;

namespace GeoLab2D.Models
{
    // Polígono formado por una lista ordenada de vértices.
    // El último vértice se une con el primero.
    public class Polygon2D
    {
        public string Name;
        public List<Vector2D> Vertices;

        public Polygon2D(string name, List<Vector2D> vertices)
        {
            Name = name;
            Vertices = vertices;
        }

        public double Area()
        {
            return GeometryOperations.PolygonArea(Vertices);
        }

        public double Perimeter()
        {
            return GeometryOperations.Perimeter(Vertices);
        }

        // Devuelve un polígono nuevo con todos los vértices transformados (no modifica el original)
        public Polygon2D Transform(Matrix3x3 m)
        {
            List<Vector2D> result = new List<Vector2D>();
            foreach (Vector2D v in Vertices)
                result.Add(m.Transform(v));
            return new Polygon2D(Name, result);
        }
    }
}

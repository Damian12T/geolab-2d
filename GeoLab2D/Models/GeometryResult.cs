namespace GeoLab2D.Models
{
    // Posibles resultados al ubicar un punto respecto de un polígono
    public enum PointLocation
    {
        Inside,
        Outside,
        OnBorder
    }

    // Resultado de proyectar un punto P sobre el segmento AB
    public class ProjectionResult
    {
        public Vector2D A;
        public Vector2D B;
        public Vector2D P;
        public Vector2D Q;          // punto más cercano sobre el segmento
        public double T;            // parámetro limitado a [0, 1]
        public double Distance;     // distancia entre P y Q
        public bool Degenerate;     // true si A y B coinciden
    }
}

namespace DataStructures.Graph
{
    public class Edge
    {
        public int Weight { get; set; }
        public bool IsIncluded { get; set; }
        public bool IsPrinted { get; set; }

        public Edge() { }
        public Edge(int weight)
        {
            Weight = weight;
            IsIncluded = false;
            IsPrinted = false;
        }
    }
}

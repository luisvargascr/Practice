using System.Collections.Generic;

namespace DataStructures.Graph
{
    public class Vertex
    {
        public bool Visited { get; set; }
        public string Name { get; set; }
        public ICollection<Vertex> Nodes { get; set; }

        public Vertex()
        {
            Name = string.Empty;
            Visited = false;
            Nodes = new List<Vertex>();
        }
    }
}

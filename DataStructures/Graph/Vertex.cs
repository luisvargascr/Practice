using System.Collections.Generic;
using System.Text;

namespace DataStructures.Graph
{
    public class Vertex
    {
        public bool Visited { get; set; }
        public string Label { get; set; }
        public Dictionary<Vertex, Edge> Edges { get; set; }

        public Vertex()
        {
            Visited = false;
            Edges = new Dictionary<Vertex, Edge>();
        }
        public Vertex(string label)
        {
            Label = label;
            Visited = false;
            Edges = new Dictionary<Vertex, Edge>();
        }
        public void AddEdge(Vertex vertex, Edge edge)
        {
            if (Edges.ContainsKey(vertex))
            {
                if (edge.Weight < Edges[vertex].Weight)
                {
                    Edges[vertex] = edge;
                }
            }
            else
            {
                Edges.Add(vertex, edge);
            }
        }
        public KeyValuePair<Vertex, Edge> NextMinimum()
        {
            Edge NextMinimum = new Edge(int.MaxValue);
            Vertex NextVertex = this;

            foreach (KeyValuePair<Vertex, Edge> item in Edges)
            {
                if (!item.Key.Visited)
                {
                    if (!item.Value.IsIncluded)
                    {
                        if (item.Value.Weight < NextMinimum.Weight)
                        {
                            NextMinimum = item.Value;
                            NextVertex = item.Key;
                        }
                    }
                }
            }
            return new KeyValuePair<Vertex, Edge>(NextVertex, NextMinimum);
        }
        public void ResetPrinting()
        {
            foreach (KeyValuePair<Vertex, Edge> vertex in Edges)
            {
                if (vertex.Value.IsPrinted)
                {
                    vertex.Value.IsPrinted = false;
                }
            }
        }
        public string PrintOriginalGraph()
        {
            StringBuilder builder = new StringBuilder();
    
            foreach (KeyValuePair<Vertex, Edge> vertex in Edges)
            {
                if (!vertex.Value.IsPrinted)
                {
                    builder.AppendLine(string.Format("{0} --- {1} --- {2}", this.Label, vertex.Value.Weight.ToString(), vertex.Key.Label));
                    vertex.Value.IsPrinted = true;
                }
            }
            return builder.ToString();
        }
        public string PrintNewGraph()
        {
            StringBuilder builder = new StringBuilder();

            if (Visited)
            {
                foreach (KeyValuePair<Vertex, Edge> vertex in Edges)
                {
                    if (vertex.Value.IsIncluded)
                    {
                        if (!vertex.Value.IsPrinted)
                        {
                            builder.AppendLine(string.Format("{0} --- {1} --- {2}", this.Label, vertex.Value.Weight.ToString(), vertex.Key.Label));
                            vertex.Value.IsPrinted = true;
                        }
                    }
                }
            }
            return builder.ToString();
        }
    }
}

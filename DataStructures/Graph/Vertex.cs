using System.Collections.Generic;
using System.Text;

namespace DataStructures.Graph
{
    public class Vertex
    {
        public bool Visited { get; set; }
        public string Label { get; set; }
        public Dictionary<Vertex, Edge> Edges { get; set; }

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
        public string OriginalToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<Vertex, Edge> pair in Edges)
            {
                if (!pair.Value.IsPrinted)
                {
                    sb.Append(Label);
                    sb.Append(" --- ");
                    sb.Append(pair.Value.Weight);
                    sb.Append(" --- ");
                    sb.Append(pair.Key.Label);
                    sb.Append("\n");
                    pair.Value.IsPrinted = true;
                }
            }
            return sb.ToString();
        }
        public string IncludedToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Visited)
            {
                foreach (KeyValuePair<Vertex, Edge> pair in Edges)
                {
                    if (pair.Value.IsIncluded)
                    {
                        if (!pair.Value.IsPrinted)
                        {
                            sb.Append(Label);
                            sb.Append(" --- ");
                            sb.Append(pair.Value.Weight);
                            sb.Append(" --- ");
                            sb.Append(pair.Key.Label);
                            sb.Append("\n");
                            pair.Value.IsPrinted = true;
                        }
                    }
                }
            }
            return sb.ToString();
        }
    }
}

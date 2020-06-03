using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Graph
{
    public class Prim
    {
        private List<Vertex> _graph;

        public Prim(List<Vertex> graph)
        {
            _graph = graph;
        }
        public void Run()
        {
            if (_graph.Count > 0)
                _graph[0].Visited = true;

            while (IsDisconnected())
            {
                Edge NextMinimum = new Edge(int.MaxValue);
                Vertex NextVertex = _graph[0];

                foreach (Vertex vertex in _graph)
                {
                    if (vertex.Visited)
                    {
                        KeyValuePair<Vertex, Edge> Candidate = vertex.NextMinimum();
                        if (Candidate.Value.Weight < NextMinimum.Weight)
                        {
                            NextMinimum = Candidate.Value;
                            NextVertex = Candidate.Key;
                        }
                    }
                }
                NextMinimum.IsIncluded = true;
                NextVertex.Visited = true;
            }
        }
        private bool IsDisconnected()
        {
            foreach (Vertex vertex in _graph)
            {
                if (!vertex.Visited)
                {
                    return true;
                }
            }
            return false;
        }
        public string OriginalGraphToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Vertex vertex in _graph)
            {
                sb.Append(vertex.OriginalToString());
            }
            return sb.ToString();
        }
        public void ResetPrintHistory()
        {
            foreach (Vertex vertex in _graph)
            {
               foreach (Edge edge in vertex.Edges.Values)
                {
                    edge.IsPrinted = false;
                }
            }
        }
        public string MinimumSpanningTreeToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Vertex vertex in _graph)
            {
                sb.Append(vertex.IncludedToString());
            }
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;

namespace DataStructures.Graph
{
    public class Prim
    {
        private List<Vertex> _graph;

        public Prim(List<Vertex> graph)
        {
            _graph = graph;
        }
        public void PrintOriginalGraph()
        {

            int cnt = 0;
            foreach (Vertex vertex in _graph)
            {
                if (cnt == 0) { vertex.ResetPrinting();  };
                Console.WriteLine(vertex.PrintOriginalGraph());
                cnt++;
            }
        }
        public void PrintNewGraph()
        {
            int cnt = 0;
            foreach (Vertex vertex in _graph)
            {
                if (cnt == 0) { vertex.ResetPrinting(); };
                Console.WriteLine(vertex.PrintNewGraph());
                cnt++;
            }
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
    }
}

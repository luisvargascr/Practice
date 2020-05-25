using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Graph
{
    public class Graph2 <T>
    {
        private Dictionary<T, List<T>> _map;

        public Graph2()
        {
            _map = new Dictionary<T, List<T>>();
        }
        // This function adds a new vertex to the graph
        public void AddVertex(T s)
        {
            _map.Add(s, new List<T>());
        }
        // This function adds the edge between source to destination
        public void AddEdge(T source, T destination, Boolean bidirectional)
        {
            if (!_map.ContainsKey(source))
                AddVertex(source);
            if (!_map.ContainsKey(destination))
                AddVertex(destination);

            _map[source].Add(destination);
            if (bidirectional)
                _map[destination].Add(source);
        }
        // This function gives the count of the vertices.
        public void GetVertexCount()
        {
            Console.WriteLine(string.Format("The graph has {0} vertex.", _map.Keys.Count));
        }
        // This function gives the count of edges
        public void GetEdgesCount(bool bidirection)
        {
            int count = 0;
            foreach (T vertex in _map.Keys)
            {
                count += _map[vertex].Count;
            }
            if (bidirection)
                count /= 2;

            Console.WriteLine(string.Format("The graph has {0} edges.", count));
        }
        // This method indicates whether a vertex is present or not.
        public void HasVertex(T s)
        {
            if (_map.ContainsKey(s))
                Console.WriteLine(string.Format("The graph contains {0} as a vertex.", s));
            else
                Console.WriteLine(string.Format("The graph does not contain {0} as a vertex.", s));
        }
        // This function gives whether an edge is present
        public void HasEdge(T s, T d)
        {
            if (_map[s].Contains(d))
                Console.WriteLine(string.Format("The graph has an edge between {0} and {1}.", s, d));
            else
                Console.WriteLine(string.Format("The graph does not have an edge between {0} and {1}.", s, d));
        }
        // This function prints adjacency list of each vertex.
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (KeyValuePair<T, List<T>> vertex in _map)
            {
                builder.Append(vertex.Key.ToString() + ": ");
                foreach (T w in vertex.Value)
                {
                    builder.Append(w.ToString() + " ");
                }
                builder.Append("\n");
            }
            return builder.ToString();
        }
    }
}

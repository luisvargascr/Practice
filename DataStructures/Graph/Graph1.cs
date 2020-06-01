using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Graph
{
    public class Graph1<T>
    {
        private Dictionary<T, List<T>> _map;
        private HashSet<T> _visited;

        public Graph1()
        {
            _map = new Dictionary<T, List<T>>();
            _visited = new HashSet<T>();
        }
        // Depth First Search - Recursive
        public void DFS(T vertex, bool recursive)
        {
            if (_visited.Contains(vertex))
                return;

            _visited.Add(vertex);
            Console.WriteLine(vertex.ToString());

            foreach (T item in _map[vertex])
            {
                if (!_visited.Contains(item))
                    DFS(item, true);
            }
        }
        public void SpanningTree()
        {
            _visited.Clear();
            foreach (KeyValuePair<T,List<T>> val in _map)
            {
                SpanningTreeAct(val.Key);
            }
            _visited.Clear();
        }
        private void SpanningTreeAct(T val)
        {
            _visited.Add(val);
            foreach (T adj in _map[val])
            {
                if (!_visited.Contains(adj))
                {
                    Console.WriteLine(string.Format("Node {0} adjacent to {1}.", adj.ToString(), val.ToString()));
                    SpanningTreeAct(adj);
                }
            }
        }
        // This functions implements Depth First Search
        // explores the node branch as far deep as possible before
        // being forced to backtrack and expand other nodes.
        public void DFS(T vertex)
        {
            // A, B, D, F, E, C, G
            //Nodes can be labelled as discovered by storing them
            //in a set, or by an attribute on each node
            _visited.Clear();
            Stack<T> stack = new Stack<T>();
            stack.Push(vertex);

            while (stack.Count != 0)
            {
                T curr = stack.Pop();

                if (!_visited.Contains(curr))
                {
                    Console.WriteLine(curr.ToString());
                    _visited.Add(curr);
                }

                List<T> adj = _map[curr];

                for (int i = adj.Count - 1; i >= 0; i--)
                {
                    T adjvertex = _map[curr][i];
                    if (!_visited.Contains(adjvertex))
                        stack.Push(adjvertex);
                }
            }
            _visited.Clear();
        }
        // This functions implements Breadth-first Search:
        // explores all of the neighbor nodes at the present depth
        // prior to moving on to the nodes at the next depth level.
        // NOT optimal to implement Recursively
        public void BFS(T start)
        {
            _visited.Clear();
            Queue<T> stack = new Queue<T>();

            //Nodes can be labelled as discovered by storing them
            //in a set, or by an attribute on each node
            stack.Enqueue(start);

            while (stack.Count > 0)
            {
                T curr = stack.Dequeue();
                if (!_visited.Contains(curr))
                {
                    _visited.Add(curr);
                    Console.WriteLine(curr.ToString());
                }
                foreach (KeyValuePair<T, List<T>> vertex in _map)
                {
                    foreach (T w in vertex.Value)
                    {
                        if (!_visited.Contains(w))
                        {
                            stack.Enqueue(w);
                        }
                    }
                }
            }
        }
        // This function adds a new vertex to the graph
        public void AddVertex(T s)
        {
            _map.Add(s, new List<T>());
        }
        // This function adds the edge between source to destination
        public void AddEdge(T source, T destination, bool bidirectional)
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
                builder.Append(string.Format("{0}: ",vertex.Key.ToString()));
                foreach (T w in vertex.Value)
                {
                    builder.Append(string.Format("{0} ", w.ToString()));
                }
                builder.Append("\n");
            }
            return builder.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Graph
{
    public class Graph1<T> where T:IComparable
    {
        private Dictionary<T, List<T>> _graph;
        private HashSet<T> _visited;

        public Graph1()
        {
            _graph = new Dictionary<T, List<T>>();
            _visited = new HashSet<T>();
        }
        private bool HasCycle(T vertex)
        {
            _visited.Add(vertex);

            foreach (T neighbor in _graph[vertex])
            {
                if (_visited.Contains(neighbor))
                    return true;
                else if (!_visited.Contains(neighbor) && HasCycle(neighbor))
                    return true;
            }

            _visited.Clear();
            return false;
        }
        public bool IsCyclic()
        {
            return HasCycle(_graph.Keys.FirstOrDefault());
        }
        private void BuildPathBetweenTwoVertices(T vertex, T end, List<T> visited, List<T> localPathList)
        {
            visited.Add(vertex);
            int index = visited.IndexOf(vertex);

            if (vertex.Equals(end))
            {
                Console.WriteLine(string.Join("->", visited));
                return;
            }
            foreach (T neighbor in _graph[vertex])
            {
                if (visited.IndexOf(neighbor) != index)
                {
                    localPathList.Add(neighbor);
                    BuildPathBetweenTwoVertices(neighbor, end, visited, localPathList);
                    localPathList.Remove(neighbor);
                }
            }
            visited.Remove(vertex);
        }
        public void FindPathBetweenTwoVertices(T s, T e)
        {
            List<T> LocalPathList = new List<T>();
            List<T> Visited = new List<T>();

            BuildPathBetweenTwoVertices(s, e, Visited, LocalPathList);
            if (Visited.Count() == 0 && LocalPathList.Count == 0)
                Console.WriteLine(string.Format("No paths between {0} and {1} were found!", s.ToString(), e.ToString()));
        }
        // Depth First Search - Recursive
        public void DFS(T vertex, bool recursive)
        {
            if (_visited.Contains(vertex))
                return;

            _visited.Add(vertex);
            Console.WriteLine(vertex.ToString());

            foreach (T neighbor in _graph[vertex])
            {
                if (!_visited.Contains(neighbor))
                    DFS(neighbor, true);
            }
        }
        public void FindSpanningTree()
        {
            _visited.Clear();

            foreach (KeyValuePair<T,List<T>> vertex in _graph)
            {
                BuildSpanningTree(vertex.Key);
            }

            _visited.Clear();
        }
        private void BuildSpanningTree(T vertex)
        {
            _visited.Add(vertex);

            foreach (T neighbor in _graph[vertex])
            {
                if (!_visited.Contains(neighbor))
                {
                    Console.WriteLine(string.Format("Node {0} adjacent to {1}.", neighbor.ToString(), vertex.ToString()));
                    BuildSpanningTree(neighbor);
                }
            }
        }
        // This functions implements Depth First Search
        // explores the node branch as far deep as possible before
        // being forced to backtrack and expand other nodes.
        // Iterative Implementation of DFS.
        public void DFS(T vertex)
        {
            // A, B, D, F, E, C, G
            //Nodes can be labelled as discovered by storing them
            //in a set, or by an attribute on each node

            _visited.Clear();
            Stack<T> stack = new Stack<T>();
            stack.Push(vertex);

            while (stack.Count > 0)
            {
                T curr = stack.Pop();

                if (!_visited.Contains(curr))
                {
                    Console.WriteLine(curr.ToString());
                    _visited.Add(curr);
                }

                List<T> neighbors = _graph[curr];

                for (int i = neighbors.Count - 1; i >= 0; i--)
                {
                    T neighbor = _graph[curr][i];
                    if (!_visited.Contains(neighbor))
                        stack.Push(neighbor);
                }
            }
            _visited.Clear();
        }
        // This functions implements Breadth-first Search:
        // explores all of the neighbor nodes at the present depth
        // prior to moving on to the nodes at the next depth level.
        // Recursive NOT optimal - Use Iterative Implementation instead.
        public void BFS(T vertex)
        {
            _visited.Clear();
            Queue<T> queue = new Queue<T>();

            //Nodes can be labelled as discovered by storing them
            //in a set, or by an attribute on each node
            queue.Enqueue(vertex);

            while (queue.Count > 0)
            {
                T curr = queue.Dequeue();

                if (!_visited.Contains(curr))
                {
                    _visited.Add(curr);
                    Console.WriteLine(curr.ToString());
                }

                foreach (KeyValuePair<T, List<T>> curr_vertex in _graph)
                {
                    foreach (T neighbor in curr_vertex.Value)
                    {
                        if (!_visited.Contains(neighbor))
                        {
                            queue.Enqueue(neighbor);
                        }
                    }
                }
            }
        }
        // This function adds a new vertex to the graph
        public void AddVertex(T s)
        {
            _graph.Add(s, new List<T>());
        }
        // This function adds the edge between source to destination
        public void AddEdge(T source, T destination, bool bidirectional)
        {
            if (!_graph.ContainsKey(source))
                AddVertex(source);

            if (!_graph.ContainsKey(destination))
                AddVertex(destination);

            _graph[source].Add(destination);

            if (bidirectional)
                _graph[destination].Add(source);
        }
        // This function gives the count of the vertices.
        public void GetVertexCount()
        {
            Console.WriteLine(string.Format("The graph has {0} vertex.", _graph.Keys.Count));
        }
        // This function gives the count of edges
        public void GetEdgesCount(bool bidirection)
        {
            int count = 0;
            foreach (T vertex in _graph.Keys)
            {
                count += _graph[vertex].Count;
            }
            if (bidirection)
                count /= 2;

            Console.WriteLine(string.Format("The graph has {0} edges.", count));
        }
        // This method indicates whether a vertex is present or not.
        public void HasVertex(T s)
        {
            if (_graph.ContainsKey(s))
                Console.WriteLine(string.Format("The graph contains {0} as a vertex.", s));
            else
                Console.WriteLine(string.Format("The graph does not contain {0} as a vertex.", s));
        }
        // This function gives whether an edge is present
        public void HasEdge(T s, T d)
        {
            if (_graph[s].Contains(d))
                Console.WriteLine(string.Format("The graph has an edge between {0} and {1}.", s, d));
            else
                Console.WriteLine(string.Format("The graph does not have an edge between {0} and {1}.", s, d));
        }
        // This function prints adjacency list of each vertex.
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            foreach (KeyValuePair<T, List<T>> vertex in _graph)
            {
                builder.Append(string.Format("{0}: ",vertex.Key.ToString()));
                foreach (T neighbor in vertex.Value)
                {
                    builder.Append(string.Format("{0} ", neighbor.ToString()));
                }
                builder.Append("\n");
            }
            return builder.ToString();
        }
    }
}
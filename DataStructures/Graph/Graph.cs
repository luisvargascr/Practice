using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Graph
{
    public class Graph
    {
        public ICollection<Vertex> Vertices { get; set; }
        public Graph()
        {
            Vertices = new List<Vertex>();
        }
        public void DepthFirstSearch(Vertex vertex, int cnt)
        {
            if (vertex == null)
                return;

            if (vertex.Visited)
                return;

            Console.WriteLine("{0}) Node: '{1}'",cnt.ToString(),vertex.Name);
            vertex.Visited = true;

            foreach (Vertex neighbor in vertex.Nodes)
            {
                if (!neighbor.Visited)
                    DepthFirstSearch(neighbor, ++cnt);
            }
        }
        public void DepthFirstSearchNR(Vertex vertex)
        {
            if (!this.Vertices.Contains(vertex))
                return;

            var Stack = new Stack<Vertex>();
            var cnt = 0;
            Stack.Push(vertex);

            while (Stack.Count > 0)
            {
                var currVertex = Stack.Pop();

                if (currVertex.Visited)
                    continue;

                Console.WriteLine("{0}) Node: '{1}'", ++cnt, currVertex.Name);
                currVertex.Visited = true;

                foreach (Vertex neighbor in vertex.Nodes)
                {
                    if (!neighbor.Visited)
                        Stack.Push(neighbor);
                }
            }
        }
        public void BreadthFirstSearchNR(Vertex vertex)
        {
            if (!this.Vertices.Contains(vertex))
                return;

            var Queue = new Queue<Vertex>();
            var cnt = 0;
            Queue.Enqueue(vertex);

            while (Queue.Count > 0)
            {
                var currVertex = Queue.Dequeue();

                if (currVertex.Visited)
                    continue;

                Console.WriteLine("{0}) Node: '{1}'", ++cnt, currVertex.Name);
                currVertex.Visited = true;

                foreach (Vertex neighbor in vertex.Nodes)
                {
                    if (!neighbor.Visited)
                        Queue.Enqueue(neighbor);
                }
            }
        }
        public bool RouteBetweenNodes(Vertex nodeA, Vertex nodeB)
        {
            if (nodeA == null)
                return false;

            if (nodeB == null)
                return false;

            var neighbors = new Queue<Vertex>();
            neighbors.Enqueue(nodeA);

            while (neighbors.Count > 0)
            {
                var currNeighbor = neighbors.Dequeue();

                if (currNeighbor.Visited)
                    continue;

                currNeighbor.Visited = true;

                foreach (Vertex neighbor in currNeighbor.Nodes)
                {
                    if (neighbor.Name.Equals(nodeB.Name, StringComparison.InvariantCultureIgnoreCase))
                    {
                        return true;
                    }
                    neighbors.Enqueue(neighbor);
                }
            }
            return false;
        }
        public void TopologicalSort()
        {
            var results = new Stack<Vertex>();
            var visited = new List<Vertex>();
            var pending = new List<Vertex>();

            Visit(Vertices, results, visited, pending);
            int cnt = 0;

            foreach (Vertex x in results)
            {
                if (++cnt == results.Count)
                    Console.Write(x.Name);
                else
                    Console.Write(x.Name + "->");
            }
        }

        private void Visit(ICollection<Vertex> graph, Stack<Vertex> results, ICollection<Vertex> visited, ICollection<Vertex> pending)
        {
            // Foreach node in the graph
            foreach (var n in graph)
            {
                // Skip if node has been visited
                if (!visited.Contains(n))
                {
                    if (!pending.Contains(n))
                    {
                        pending.Add(n);
                    }
                    else
                    {
                        Console.WriteLine(String.Format("Cycle detected (node Data={0})", n.Name));
                        return;
                    }

                    // recursively call this function for every child of the current node
                    Visit(n.Nodes, results, visited, pending);

                    if (pending.Contains(n))
                    {
                        pending.Remove(n);
                    }

                    visited.Add(n);

                    // Made it past the recusion part, so there are no more dependents.
                    // Therefore, append node to the output list.
                    results.Push(n);
                }
            }
        }
    }
}

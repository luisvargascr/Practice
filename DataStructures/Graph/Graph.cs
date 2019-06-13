using System;
using System.Collections.Generic;

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
    }
}

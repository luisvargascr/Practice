using System;
namespace DataStructures.Graph
{
    public class StackX
    {
        private const int SIZE = 20;
        private int[] _st;
        private int _top;

        public StackX()
        {
            _st = new int[SIZE];
            _top = -1;
        }
        public void Push (int j)
        {
            _st[++_top] = j;
        }
        public int Pop ()
        {
            return _st[_top--];
        }
        public int Peek()
        {
            return _st[_top];
        }
        public bool IsEmpty()
        {
            return _top == -1;
        }
    }
    public class VertexN<T> where T:IComparable
    {
        public T Label { get; set; }
        public bool WasVisited { get; set; }

        public VertexN(T lab)
        {
            Label = lab;
            WasVisited = false;
        }
    }
    public class Graph2<T> where T:IComparable
    {
        private const int MAX_VERTS = 20;
        private VertexN<T> [] _vertexList;
        private int[,] _adjMat;
        private int _nVerts;
        private StackX _stack;

        public Graph2()
        {
            _vertexList = new VertexN<T>[MAX_VERTS];
            _adjMat = new int[MAX_VERTS, MAX_VERTS];
            _nVerts = 0;

            for (int j = 0; j < MAX_VERTS; j++)
                for (int k = 0; k < MAX_VERTS; k++)
                    _adjMat[j, k] = 0;

            _stack = new StackX();
        }
        public void AddVertex(T lab)
        {
            _vertexList[_nVerts++] = new VertexN<T>(lab);
        }
        public void AddEdge(int start, int end)
        {
            _adjMat[start, end] = 1;
            _adjMat[end, start] = 1;
        }
        public void DisplayVertex(int v)
        {
            Console.WriteLine(_vertexList[v].Label);
        }
        public int GetAdjUnvisitedVertex(int v)
        {
            for (int j = 0; j < _nVerts; j++)
            {
                if (_adjMat[v, j] == 1 && !_vertexList[j].WasVisited)
                    return j;
            }
            return -1;
        }
        public void DFS()
        {
            _vertexList[0].WasVisited = true;
            DisplayVertex(0);
            _stack.Push(0);

            while(!_stack.IsEmpty())
            {
                int v = GetAdjUnvisitedVertex(_stack.Peek());

                if (v == -1)
                    _stack.Pop();
                else
                {
                    _vertexList[v].WasVisited = true;
                    DisplayVertex(v);
                    _stack.Push(v);
                }
            }
            for (int j = 0; j < _nVerts; j++)
                _vertexList[j].WasVisited = false;
        }
    }
}

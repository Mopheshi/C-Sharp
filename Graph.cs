namespace C_Sharp
{
    // We define a 'Graph' class that represents a directed graph using an adjacency list.
    internal class Graph
    {
        /**
         * @author Mopheshi
         * 
         * This implementation assumes that the graph is represented using adjacency lists.
         * The Graph class has methods to add edges and perform Breadth First Search on the graph.
         * The Breadth First Search method takes a starting vertex s as its argument and prints the
         * vertices in Breadth First Search order.
         * 
         * This algorithm traverses the graph in a breadth-first manner, i.e.,
         * it visits all the vertices at distance 1 from the starting vertex, then all the vertices at
         * distance 2, and so on.
         */

        private int V; // number of vertices
        private List<int>[] adj; // adjacency list

        public Graph(int v)
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; i++)
            {
                adj[i] = new List<int>();
            }
        }

        // Adds an edge between two vertices.
        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
        }

        // Performs BFS
        public void BreadthFirstSearch(int s)
        {
            bool[] visited = new bool[V];

            Queue<int> queue = new Queue<int>();
            visited[s] = true;
            queue.Enqueue(s);

            while (queue.Count != 0)
            {
                s = queue.Dequeue();
                Console.Write(s + " ");

                foreach (int i in adj[s])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        queue.Enqueue(i);
                    }
                }
            }
        }

        public int[] TopologicalSort()
        {
            Stack<int> stack = new Stack<int>();
            bool[] visited = new bool[V];

            for (int i = 0; i < V; i++)
            {
                if (!visited[i])
                {
                    DFS(i, visited, stack);
                }
            }

            int[] result = stack.ToArray();
            Array.Reverse(result);
            return result;
        }

        private void DFS(int v, bool[] visited, Stack<int> stack)
        {
            visited[v] = true;

            foreach (int neighbour in adj[v])
            {
                if (!visited[neighbour])
                {
                    DFS(neighbour, visited, stack);
                }
            }

            stack.Push(v);
        }
    }
}
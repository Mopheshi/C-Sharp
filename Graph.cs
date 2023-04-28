namespace C_Sharp
{
    internal class Graph
    {
        /**
         * @author ChatGPT
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

        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
        }

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
    }
}

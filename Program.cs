using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grafos
{
    class Program
    {
        /*
        public List<object> DijkstrasAlgorithm(MyList graf, Nodo start) {

            Dictionary<Nodo, int> totalCost = new Dictionary<Nodo, int>(); //Guarda el costo total del camino
            Dictionary<Nodo, Nodo> prevNodes = new Dictionary<Nodo, Nodo>(); //Guarda el camino mas corto
            PriorityQueue<Nodo> minPQ = new PriorityQueue<Nodo>();
            //Set

            totalCost.Add(start, 0); //El costo del primer nodo/raiz en 0
            minPQ.enqueue(start); //Agrega el nodo inicial a la lista de prioridad

            for (int i = 0; i <= graf.Lenght(); i++)
            {
                if(graf.headNode )
            }
        } 
        */

            private static int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
            {
                int min = int.MaxValue;
                int minIndex = 0;

                for (int v = 0; v < verticesCount; ++v)
                {
                    if (shortestPathTreeSet[v] == false && distance[v] <= min)
                    {
                        min = distance[v];
                        minIndex = v;
                    }
                }

                return minIndex;
            }

            private static void Print(int[] distance, int verticesCount)
            {
                Console.WriteLine("Vertex    Distance from source");

                for (int i = 0; i < verticesCount; ++i)
                    Console.WriteLine("{0}\t  {1}", i, distance[i]);
            }

            public static void DijkstraAlgo(int[,] graph, int source, int verticesCount)
            {
                int[] distance = new int[verticesCount];
                bool[] shortestPathTreeSet = new bool[verticesCount];

                for (int i = 0; i < verticesCount; ++i)
                {
                    distance[i] = int.MaxValue;
                    shortestPathTreeSet[i] = false;
                }

                distance[source] = 0;

                for (int count = 0; count < verticesCount - 1; ++count)
                {
                    int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
                    shortestPathTreeSet[u] = true;

                    for (int v = 0; v < verticesCount; ++v)
                        if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                            distance[v] = distance[u] + graph[u, v];
                }

                Print(distance, verticesCount);
            }
        


            static void Main(string[] args)
        {
            /*
            MyList lista = new MyList();

           
            
            
            PriorityQueue<Nodo> miQueue = new PriorityQueue<Nodo>();

            


            //Console.WriteLine(miQueue.peek());

            lista.AddToEnd("china");
            lista.AddToEnd("venezuela");
            lista.AddToEnd("colombia");
            lista.AddToEnd("peru");
            lista.AddToEnd("Argentina");

            lista.AddToEnd("brazil");

            lista.AddNeighbour("colombia", 10, "venezuela");
            lista.AddNeighbour("colombia", 100, "peru");
            lista.AddNeighbour("colombia", 1070, "brazil");
            lista.AddNeighbour("china", 1070, "brazil");

            Console.Write(lista.Lenght());

            
            */
            int[,] graph =  {
                         { 0, 6, 0, 0, 0, 0, 0, 9, 0 },
                         { 6, 0, 9, 0, 0, 0, 0, 11, 0 },
                         { 0, 9, 0, 5, 0, 6, 0, 0, 2 },
                         { 0, 0, 5, 0, 9, 16, 0, 0, 0 },
                         { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                         { 0, 0, 6, 0, 10, 0, 2, 0, 0 },
                         { 0, 0, 0, 16, 0, 2, 0, 1, 6 },
                         { 9, 11, 0, 0, 0, 0, 1, 0, 5 },
                         { 0, 0, 2, 0, 0, 0, 6, 5, 0 }
                            };

            DijkstraAlgo(graph, 1, 9);

            Console.ReadKey();

            
        }
    }
}

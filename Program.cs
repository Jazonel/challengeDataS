using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grafos
{
    class Program
    {
         
        static void Main(string[] args)
        {
            MyList lista = new MyList();

            lista.AddToEnd("china");
            lista.AddToEnd("venezuela");
            lista.AddToEnd("colombia");
            lista.AddToEnd("peru");
            
            lista.AddToEnd("brazil");

            lista.AddNeighbour("colombia", 10, "venezuela");
            lista.AddNeighbour("colombia", 100, "peru");
            lista.AddNeighbour("colombia", 1070, "brazil");
            lista.AddNeighbour("china", 1070, "brazil");


            foreach (KeyValuePair<string, int> item in lista.headNode.conexiones)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }


            Console.ReadKey();

            
        }
    }
}

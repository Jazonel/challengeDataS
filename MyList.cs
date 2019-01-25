using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class MyList
    {
        public Nodo headNode;   //Nodo Cabeza

        //Constructor
        public MyList() {
            headNode = null;
        }

        //Agrega un nodo al final de la lista
        public void AddToEnd(string _data)
        {
            if (headNode == null)
            {
                headNode = new Nodo(_data);
            }
            else {
                headNode.AddToEnd(_data);
            }
        }

        
        //Agrega un vecino del nodo
        public void AddNeighbour(string _name, int weight, string neighbour)
        {
            headNode.AddNeighbour(_name, weight, neighbour);
        }

        //Regresa la longitud de la lista
        public int Lenght() {
            if (headNode == null)
            {
                return 0;
            }
            else {
                return headNode.Length(0);
            }
        }
           
         //Imprime la lista
         public void Print() {
            if (headNode != null)
            {
                headNode.Print();
            }
         }

        /*
        //Regresa un nodo en la lista
        public Nodo GetNodo(string _name) {
            if (headNode == null)
            {
                return null;
            }
            else {

            }
        }

        */
    }

    
}

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

        

        public void AddNeighbour(string _name, int weight, string neighbour)
        {
            headNode.AddNeighbour(_name, weight, neighbour);
        }
           
            //Imprime la lista
            public void Print() {
            if (headNode != null)
            {
                headNode.Print();
            }
        }
    }

    
}

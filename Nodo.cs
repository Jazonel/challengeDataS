using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Nodo
    {
        public string name;    //Nombre del nodo/pais
        public Dictionary<string, int> conexiones; //Conexiones del nodo
        public Nodo next;   //Siguiente nodo en la lista

        //Constructor
        public Nodo(string _name) {
            name = _name;
            next = null;
            conexiones = new Dictionary<string, int>();
        }

        //Imprimir Nodo
        public void Print() {
            Console.Write("| " + name + " |->");
            if (next != null) {
                next.Print();
            }
        }

        //Agregar vecinos de nodo en especifico
        public void AddNeighbour(string _name, int weight, string neighbour) {
            if (_name == name)
            {
                this.conexiones.Add(neighbour, weight);
            }
            else {
                next.AddNeighbour(_name, weight, neighbour);
            }
        }

        //Agrega un Nodo al final de la lista
        public void AddToEnd(string _name) {
            if (this.next == null) {
                this.next = new Nodo(_name);
            }
            else {
                next.AddToEnd(_name);
            }
        }
        
    }
}

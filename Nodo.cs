using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Nodo : IComparable
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

        //Regresa el numero de nodos que tiene la lista
        public int Length(int _acc) {
            int acc = _acc;
            if (this.next == null)
            {
                acc++;
                return acc;
            }
            else {
                acc++;
                return this.next.Length(acc);
            }
        }

        /*
        public Nodo GetNodo(Nodo headnodo, string _name) {
            if (_name == headnodo.name) {
                return 
            }
        }
        */

        private class ejemplo : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Nodo n1 = (Nodo)a;
                Nodo n2 = (Nodo)b;

                if (n1.name == n2.name)
                    return 1;
                else {
                    return 0;
                }
            }
        }

        int IComparable.CompareTo(object obj)
        {
            Nodo c = (Nodo)obj;
            return 0;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public interface Grafo <T, K>
    {
        bool AddVertex(T vertex); // si no existe ya regresa true
        void AddVertex(IEnumerable<T> vertexSet); //Agrega a el grafo los vertices contenidos en "set"
        bool DeleteVertex(T vertex);
        void DeleteVertex(IEnumerable<T> vertexSet); //Borra todos los vertices del set 
        bool AddEdge(T v1, T vs, K weight);
        K GetWeight(T v1, T v2);
        bool DeleteEdge(T v1, T v2); //Borra una arista
        bool AreAdjacent(T v1, T v2);
        int Degree(T vertex); //Computa el grado de un vertice en especifico
        int OutDegree(T vertex);
        int InDegree(T vertex);
        int VerticesNumber();
    }
}

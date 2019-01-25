using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class HeapMin<T> where T:IComparable<T>
    {
        private IComparer<T> _cmp;
    }
}

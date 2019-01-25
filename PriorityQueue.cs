using System;
using System.Collections.Generic;
using System.Linq;

namespace Grafos
{
    public interface IQueue<T>
    {
        bool isEmpty();

        T peek();

        void enqueue(T item);

        T dequeue();
    }

    public class PriorityQueue<T> : IQueue<T> where T : IComparable
    {
        private LinkedList<T> data = new LinkedList<T>();

        public bool isEmpty()
        {
            return data.Count == 0;
        }

        public T peek()
        {
            if (!isEmpty())
            {
                return data.ElementAt(0);
            }
            else
            {
                return default(T);
            }
        }

        public void enqueue(T item)
        {
            data.AddLast(item);

            int cIndex = data.Count - 1;
            int pIndex = (cIndex - 1) / 2;

            while (data.ElementAt(cIndex).CompareTo(data.ElementAt(pIndex)) < 0)
            {
                T temp = data.ElementAt(cIndex);
                data.Find(temp).Value = data.ElementAt(pIndex);
                data.Find(data.ElementAt(pIndex)).Value = temp;

                cIndex = pIndex;
                pIndex = (cIndex - 1) / 2;
            }
        }


        public T dequeue()
        {
            if (data.Count == 0)
            {
                return default(T);
            }
            else if (data.Count == 1)
            {
                T temp = data.ElementAt(0);
                data.Remove(temp);
                return temp;
            }
            else
            {
                T toReturn = data.ElementAt(0);

                T last = data.ElementAt(data.Count - 1);
                data.Remove(last);

                data.Find(data.ElementAt(0)).Value = last;

                int pIndex = 0;
                while (true)
                {
                    int lIndex = 2 * pIndex + 1, lesserChildIndex = lIndex;
                    if (lIndex >= data.Count)
                    {
                        break;
                    }

                    int rIndex = lIndex + 1;
                    if (rIndex < data.Count && data.ElementAt(rIndex).CompareTo(data.ElementAt(lIndex)) < 0)
                    {
                        lesserChildIndex = rIndex;
                    }

                    if (data.ElementAt(lesserChildIndex).CompareTo(data.ElementAt(pIndex)) < 0)
                    {
                        T temp = data.ElementAt(lesserChildIndex);
                        data.Find(temp).Value = data.ElementAt(pIndex);
                        data.Find(data.ElementAt(pIndex)).Value = temp;

                        pIndex = lesserChildIndex;
                    }
                    else
                    {
                        break;
                    }
                }

                return toReturn;
            }
        }

        public override string ToString()
        {
            return data.ToString();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwBuildGenerics.Ex3
{
    public class GenericQueue <T>
    {
        private LinkedList<T> items=new LinkedList<T>();

        public void Enqueue(T item)
        {
            items.AddLast(item);
        }

        public T Dequeue()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            T value = items.First.Value;
            return value;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return items.First.Value;
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }
    }
}

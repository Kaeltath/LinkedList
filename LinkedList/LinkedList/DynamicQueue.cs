using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DynamicQueue<T> : IMyQueue<T>, IPrintable
    {
        private int MaxSize = 39;
        LinkedList<T> Buffer = new LinkedList<T>();
        



        public void Enqueue(T ElementToEnqueue)
        {
            if (Buffer.Size < MaxSize)
            {
                Buffer.Add(ElementToEnqueue);
            }
            else
            {
                Console.WriteLine("Buffer is Full");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        public T Dequeue()
        {
            T temp = Buffer.Get(1);
            Buffer.Remove(1);
            return temp;
        }

        public void Print()
        {
            Buffer.Print();
        }
    }
}

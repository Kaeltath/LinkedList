using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{    
    class DynamicStack<T> 
    {
        private int MaxSize = 79;
        LinkedList<T> Buffer = new LinkedList<T>();

        public void Push(T toPushValue)
        {

            if (Buffer.Size < MaxSize)
            {
               Buffer.Add(toPushValue);
            }
            else
            {
                Console.WriteLine("Buffer is Full");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        public T Pop()
        {
            T temp;
            temp = Buffer.Get(Buffer.Size);
            Buffer.Remove(Buffer.Size);
            return temp;
        }

        public T Peek()
        {
            return Buffer.Get(Buffer.Size);
        }

        public void Print()
        {
            Buffer.Print();
        }
    }
}

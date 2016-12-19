using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    interface IMyQueue<T>: IPrintable
    {
        void Enqueue(T ElementToEnqueue);
        T Dequeue();

    }
}

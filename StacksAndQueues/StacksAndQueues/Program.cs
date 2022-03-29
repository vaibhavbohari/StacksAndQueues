using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Creating object
            //LinkedListStack my_Stack = new LinkedListStack();
            //my_Stack.Push(70);
            //my_Stack.Push(30);
            //my_Stack.Push(56);
            //my_Stack.Display();
            //my_Stack.IsEmpty();



            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            queue.Dequeue();
            queue.Display();
        }
    }
}







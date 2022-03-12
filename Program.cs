using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack stack = new Stack();
            //stack.Push(56);
            //stack.Push(30);
            //stack.Push(70);

            //int PeakElement = stack.Peak();
            //Console.WriteLine("Peak top Element of the stack : " + PeakElement);

            //stack.Pop();
            //Console.WriteLine("After Poping the Element ");
            //stack.Display();


            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);

        }
    }
}

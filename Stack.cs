using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueProblems
{
    class Stack
    {
        internal Node top;
        public Stack()
        {
            this.top = null;
        }

        //pushing into stack
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.Next = top;
                top = newNode;
            }
            Console.WriteLine("{0} Pushed to Stack ", data);
        }
    }
}

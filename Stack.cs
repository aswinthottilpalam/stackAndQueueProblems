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
        public bool isEmpty()
        {
            return top == null;
        }
        public int Peak()
        {
            if (!isEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
        }
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            top = top.Next;
        }
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.WriteLine("{0} ", temp.data);
                    temp = temp.Next;
                }

            }
        }
    }
}

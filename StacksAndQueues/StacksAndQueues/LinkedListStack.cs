using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class LinkedListStack
    {

        public Node top;
        public LinkedListStack()
        {
            this.top = null;
        }

        /// <summary>
        /// Method to push element in the stack
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine(value + " pushed to stack");
        }

        /// <summary>
        /// Method to display stack
        /// </summary>
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        /// <summary>
        /// Returns the top element of stack without deleting it
        /// </summary>
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("\n" + this.top.data + " is in the top of the stack");
        }

        /// <summary>
        /// Delete the topmost element
        /// </summary>
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is " + this.top.data);
            this.top = this.top.next;
        }

        /// <summary>
        /// Check if the stack is empty
        /// </summary>
        public void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            Console.WriteLine("Stack is empty");
        }
    }
}


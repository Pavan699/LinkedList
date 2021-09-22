using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProgram
{
    class LinkedList<T>
    {
        public Node<T> head;
        /// <summary>
        /// Addfirst() method to add all the elements at the First position...
        /// </summary>
        /// <param name="data"></param>
        public void Addfirst(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                var newNode = new Node<T>(data);
                newNode.next = this.head;
                head = newNode;
            }
        }

        /// <summary>
        /// Append method to add the elements at the last....
        /// </summary>
        /// <param name="data">data contains the value</param> 
        public void Append(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        /// <summary>
        /// Print() Method to print the list 
        /// </summary>
        public void Print()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List Is Empty");
            }
            while (temp != null)
            {
                Console.Write(" " + temp.data);
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}

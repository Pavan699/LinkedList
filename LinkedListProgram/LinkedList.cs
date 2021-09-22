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
        /// Insert() method to the add element to specific position
        /// </summary>
        /// <param name="position">It Represent Index where to add the element</param>
        /// <param name="data">contains the value</param>
        public void Insert(int position, T data)
        {
            if (position < 1)
            {
                Console.WriteLine("Wrong Position : {0}", position);
            }
            if (position == 1)
            {
                var newNode = new Node<T>(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node<T> temp = this.head;
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node<T> node = new Node<T>(data);
                        node.next = temp.next;
                        temp.next = node;
                        break;
                    }
                    temp = temp.next;
                }
                if (position != 1)
                    Console.WriteLine("Position Out Of Range");
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
        /// <summary>
        /// DeleteFirst() Method to remove the elements from first position
        /// </summary>
        public void DeleteFirst()
        {
            if (this.head == null)
            {
                Console.WriteLine("List is Empty");
            }
            head = head.next;
        }

        /// <summary>
        /// DeleteLast() Method to remove the elements from Last position
        /// </summary>
        public void DeleteLast()
        {
            Node<T> temp = this.head;
            if (this.head == null)
            {
                Console.WriteLine("List is Empty");
            }
            if (head.next == null)
            {
                head = null;
            }
            else
            {
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
            }
        }
    }
}

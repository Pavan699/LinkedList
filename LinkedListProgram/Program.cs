using System;
using System.Collections.Generic;

namespace LinkedListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Program Solution");
            LinkedList<int> llist = new LinkedList<int>();//declaration of linked list
            llist.AddFirst(56);//inbuild methds(Addfirst,AddLast,)
            llist.AddLast(30);
            llist.AddLast(70);
            Console.WriteLine("Printing Normal Linked List : 56,30,70");
            foreach(var i in llist)//printing the Linked List
            {
                Console.WriteLine("Element is : "+i);
            }
        }
    }
}

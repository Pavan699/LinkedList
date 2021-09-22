using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProgram
{
    class Choice
    {
        public void Input()
        {
            LinkedList<int> llist = new LinkedList<int>();//declaration of linked list
            llist.Addfirst(70);
            llist.Addfirst(30);
            llist.Addfirst(56);
            llist.Print();

            /*llist.Append(56);//calling Append method
            llist.Append(30);
            llist.Append(70);
            llist.Print();*/

            /*llist.Addfirst(70);            
            llist.Addfirst(56);
            llist.Insert(2, 30);
            llist.Print();*/

            /*llist.DeleteFirst();
            llist.Print();*/

            /*llist.DeleteLast();
            llist.Print();*/

            bool check = llist.Search(30);
            if(check == true)
            {
                Console.WriteLine("Element {0} is Present",30);
            }
            else
            {
                Console.WriteLine("Element {0} is Absent", 30);
            }

        }

    }
}

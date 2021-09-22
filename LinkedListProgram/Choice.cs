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
        }

    }
}

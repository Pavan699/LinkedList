using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProgram
{
    class Node<T>//generic type
    {
        public T data;//class instance
        public Node<T> next;
        public Node(T data)//constructor to assing the data
        {
            this.data = data;
            this.next = null;
        }
    }
}

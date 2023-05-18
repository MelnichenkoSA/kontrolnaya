using System;
using System.Collections.Generic;
using System.Text;

namespace kontrolnaya
{
    class Stack<T>
    {
        public Listik<T> list;
        public Stack()
        {
            list = new Listik<T>();
        }
        public void Push(T data)
        {
            Node<T> node1 = new Node<T>(data);
            node1.next = list.first;
            list.first = node1;
        }
    }
}

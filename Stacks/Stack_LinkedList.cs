using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Stack_LinkedList
    {
        private Node _first = null;

        private class Node
        {
            public string Cargo { get; set; }
            public Node Next { get; set; }  
        }

        public int Size { get; set; } = 0;
        public void Push(string newString)
        {
            var oldFirst = _first;
            _first = new Node() {Cargo = newString, Next = oldFirst};
            Size++;
        }

        public string Pop()
        {
            var oldFirst = _first;
            _first = _first.Next;
            Size--;
            return oldFirst.Cargo;
        }

        public bool IsEmply()
        {
            return Size == 0;
        }

    }
}

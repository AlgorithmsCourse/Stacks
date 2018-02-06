using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Stack_FixedSize
    {
        public string[] Strings { get; set; }
        public int N { get; set; } = 0;

        public Stack_FixedSize(int capacity)
        {
            Strings = new string[capacity];
        }

        public void Push(string newString)
        {
            Strings[N] = newString;
            N++;
        }

        public string Pop()
        {
            var removedString = Strings[N - 1];
            N--;
            return removedString;
        }

        public bool IsEmpty()
        {
            return N == 0;
        }

        public int Size() => N;


    }
}

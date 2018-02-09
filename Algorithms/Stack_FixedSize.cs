using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Stack_FixedSize
    {
        private string[] _strings;
        private int _n  = 0;

        public Stack_FixedSize(int capacity)
        {
            _strings = new string[capacity];
        }

        public void Push(string newString)
        {
            _strings[_n] = newString;
            _n++;
        }

        public string Pop()
        {
            var removedString = _strings[_n - 1];
            _n--;
            return removedString;
        }

        public bool IsEmpty()
        {
            return _n == 0;
        }

        public int Size() => _n;


        public void SeeStack()
        {
            for (var i = _n-1; i < 0; i--)
            {
                Console.WriteLine(_strings[i]);
            }
        }   
            

}
}

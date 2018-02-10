using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Stack_ResizingArray
    {
        private string[] _strings = new string[1];
        private int _n = 0;

        public void Push(string newString)
        {
            if (_n ==_strings.Length)
            {
                Resize(_strings.Length*2);
            }
            _strings[_n] = newString;
            _n++;
        }
        public string Pop()
        {
            var removed = _strings[_n - 1];
            _n--;
            if (_n < _strings.Length / 4)
            {
                Resize(_strings.Length/2);
            }
            return removed;
        }
        public bool IsEmpty() => _n == 0;

        public int Size() => _n;

        public void Resize(int newCap)
        {
            var ReSizedArray = new string[_n * 2];
            for (int i = 0; i < _n; i++)
            {
                ReSizedArray[i] = _strings[i];
            }
            _strings = ReSizedArray;
        }
    }
}

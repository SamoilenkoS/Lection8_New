using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lection8_New
{
    public class Number : IEnumerable<char>//1234 => 1 => 2 => 3 => 4
    {
        private int _number;

        public Number(int number)
        {
            _number = number;
        }

        public IEnumerator<char> GetEnumerator()
        {
            string current = _number.ToString();

            for (int i = 0; i < current.Length; i++)
            {
                yield return current[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

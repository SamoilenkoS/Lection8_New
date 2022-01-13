using System;
using System.Collections.Generic;
using System.Text;

namespace Lection8_New
{
    public class MaxMethod<T> where T : IComparable<T>
    {
        public static T Max(T a, T b)
        {
            return a.CompareTo(b) == 1 ? a : b;
        }
    }
}

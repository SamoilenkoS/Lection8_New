using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lection8_New
{
    public class DogsByNameComparer : IComparer<Dog>
    {
        public int Compare([AllowNull] Dog x, [AllowNull] Dog y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}

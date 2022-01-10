using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lection8_New
{
    public sealed class Dog : IAnimal, IComparable<Dog>
    {
        public string Name;

        public int Age;

        public static int Count;

        static Dog()
        {
            Count = -10;
        }

        public Dog()
        {
            ++Count;
        }

        public string SaySound()
        {
            return $"{Name} Wof";
        }

        public int CompareTo([AllowNull] Dog other)
        {
            int result = Age.CompareTo(other.Age);
            if(result == 0)
            {
                result = Name.CompareTo(other.Name);
            }

            return result;
        }
    }
}

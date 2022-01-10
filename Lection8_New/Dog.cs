using System;
using System.Collections.Generic;
using System.Text;

namespace Lection8_New
{
    public sealed class Dog : IAnimal
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
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lection8_New
{
    public static class HW1Helper
    {
        public static int AToPowerB(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }

        public static int Square(this int a)
        {
            return a * a;
        }

        //public static string Wof(this Dog dog)
        //{
        //    return $"{dog.Name} Wof";
        //}
    }
}

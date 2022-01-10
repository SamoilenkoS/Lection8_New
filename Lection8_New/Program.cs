using System;
using System.Collections.Generic;

namespace Lection8_New
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cat cat = new Cat();
            //cat.AddKittenName("K1");
            //cat.AddKittenName("K2");
            //foreach (var kitten in cat)
            //{
            //    Console.WriteLine(kitten);
            //}
            Number num = new Number(123456);

            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }
    }
}

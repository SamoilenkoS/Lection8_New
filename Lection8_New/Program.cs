using System;
using System.Collections.Generic;

namespace Lection8_New
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        static void Sort(int[] array, bool ascending = true)
        {
            var coef = ascending ? 1 : -1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[i].CompareTo(array[j]) == coef)
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            //Cat cat = new Cat();
            //cat.AddKittenName("K1");
            //cat.AddKittenName("K2");
            //foreach (var kitten in cat)
            //{
            //    Console.WriteLine(kitten);
            //Dog[] dogs = new Dog[3];
            //dogs[0] = new Dog();
            //dogs[0].Age = 10;
            //dogs[1] = new Dog();
            //dogs[1].Age = 5;
            //dogs[2] = new Dog();
            //dogs[2].Age = 7;
            //Array.Sort(dogs);

            //foreach (var dog in dogs)
            //{
            //    Console.WriteLine(dog.Age);
            //}
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 20);
                Console.Write($"{array[i]}\t");
            }

            Console.WriteLine();

            Sort(array, false);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
            }
        }
    }
}

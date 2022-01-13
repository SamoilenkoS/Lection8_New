using System;
using System.Collections.Generic;
using System.IO;

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
            Dog[] dogs = new Dog[3];
            dogs[0] = new Dog();
            dogs[0].Name = "CCC";
            dogs[0].Age = 3;
            dogs[1] = new Dog();
            dogs[1].Name = "AAA";
            dogs[1].Age = 3;
            dogs[2] = new Dog();
            dogs[2].Name = "BBB";
            dogs[2].Age = 4;
            var result = MaxMethod<int>.Max(10, 20);
            var r2 = MaxMethod<double>.Max(30, 15);
            var r3 = MaxMethod<char>.Max('1', '3');
            var r4 = MaxMethod<Dog>.Max(dogs[0], dogs[1]);

            Console.WriteLine(result);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            Console.WriteLine(r4.Name);
            //using(DisposableSomething dp = new DisposableSomething())
            //{
            //    dp.WriteSomething("Hello");
            //    dp.WriteSomething("world!");
            //}

            //using (
            //    StreamWriter streamWritter = new StreamWriter("Hello.txt"))
            //{
                
            //}
            //Cat cat = new Cat();
            //cat.AddKittenName("K1");
            //cat.AddKittenName("K2");
            //foreach (var kitten in cat)
            //{
            //    Console.WriteLine(kitten);
            
            //Array.Sort(dogs);

            //foreach (var dog in dogs)
            //{
            //    Console.WriteLine(dog.Name + " " + dog.Age);
            //}
            //int[] array = new int[10];
            //Random random = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(1, 20);
            //    Console.Write($"{array[i]}\t");
            //}

            //Console.WriteLine();

            //Sort(array, false);

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"{array[i]}\t");
            //}
        }
    }
}

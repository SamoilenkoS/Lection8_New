using System;
using System.Collections.Generic;

namespace Lection8_New
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Name = "bobik";
            Cat c = new Cat();
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(d);
            animals.Add(c);
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.SaySound());
            }
        }
    }
}

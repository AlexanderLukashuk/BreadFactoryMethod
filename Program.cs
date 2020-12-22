using System;
using BreadFactoryMethod.Interfaces;
using BreadFactoryMethod.Models;

namespace BreadFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IBreadFactory factory = new LoafFactory();
            IBread bread = factory.CreateBread();
            bread.Slice();

            Console.ReadLine();
        }
    }
}

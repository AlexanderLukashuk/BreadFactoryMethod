using System;
using BreadFactoryMethod.Interfaces;

namespace BreadFactoryMethod.Models
{
    public class Bun : IBread
    {
        public void Slice()
        {
            Console.WriteLine("Нарезана булка");
        }
    }
}
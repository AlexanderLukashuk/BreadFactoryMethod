using System;
using BreadFactoryMethod.Interfaces;

namespace BreadFactoryMethod.Models
{
    public class Loaf : IBread
    {
        public void Slice()
        {
            Console.WriteLine("Нарезана батон");
        }
    }
}
using System;
using BreadFactoryMethod.Interfaces;

namespace BreadFactoryMethod.Models
{
    public class Flapjack : IBread
    {
        public void Slice()
        {
            Console.WriteLine("Нарезана лепешка");
        }
    }
}
using BreadFactoryMethod.Interfaces;

namespace BreadFactoryMethod.Models
{
    public class BunFactory : IBreadFactory
    {
        public IBread CreateBread()
        {
            return new Bun();
        }
    }
}
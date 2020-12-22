using BreadFactoryMethod.Interfaces;

namespace BreadFactoryMethod.Models
{
    public class LoafFactory : IBreadFactory
    {
        public IBread CreateBread()
        {
            return new Loaf();
        }
    }
}
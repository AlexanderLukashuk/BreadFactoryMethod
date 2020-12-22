using BreadFactoryMethod.Interfaces;

namespace BreadFactoryMethod.Models
{
    public class FlapjackFactory : IBreadFactory
    {
        public IBread CreateBread()
        {
            return new Flapjack();
        }
    }
}
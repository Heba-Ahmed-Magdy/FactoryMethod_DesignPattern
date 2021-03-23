using FactoryMethodDP.Fans;

namespace FactoryMethodDP.Factories
{
    public class WallFanFactory : IFanFactory
    {
        public IFan Create()
        {
            return new WallFan();
        }
    }
}
using FactoryMethodDP.Fans;

namespace FactoryMethodDP.Factories
{
    public class CeilingFanFactory : IFanFactory
    {
        public IFan Create()
        {
            return new ceillingFan();
        }
    }
}
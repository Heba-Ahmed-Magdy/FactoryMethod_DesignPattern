using FactoryMethodDP.Fans;

namespace FactoryMethodDP.Factories
{
    public interface IFanFactory
    {
        //Factory method
        IFan Create();
    }
}
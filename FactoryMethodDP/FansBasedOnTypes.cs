using FactoryMethodDP.Factories;
using System.Collections.Generic;

namespace FactoryMethodDP
{
    public static class FansBasedOnTypes
    {
        private static Dictionary<FanTypes, IFanFactory> keyValuePairs = new Dictionary<FanTypes, IFanFactory>
        {
            {FanTypes.Wall, new WallFanFactory() },
            {FanTypes.Celling, new CeilingFanFactory() }
        };

        public static Dictionary<FanTypes, IFanFactory> KeyValuePairs { get => keyValuePairs; }
    }
}
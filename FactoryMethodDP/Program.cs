using System;

namespace FactoryMethodDP
{
    class Program
    {
        //https://stackoverflow.com/questions/737917/all-enum-items-to-string-c
        //https://stackoverflow.com/questions/16100/convert-a-string-to-an-enum-in-c-sharp
        //https://code-maze.com/factory-method/
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Plz choose Type From the following Fans : {String.Join(", ", Enum.GetNames(typeof(FanTypes)))}");
                var fanType = Console.ReadLine();
                FanTypes type;
                var isParsed = Enum.TryParse<FanTypes>(fanType, out type);
                if (!isParsed)
                    return;
                var factory = FansBasedOnTypes.KeyValuePairs[type];
                Console.WriteLine($"Type is :: {factory.Create().GetType()}");
            }
        }
    }
}

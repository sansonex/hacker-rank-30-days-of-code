using System;
using System.Linq;
using System.Reflection;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            var challengeType = typeof(Challenge);

            var types = Assembly.GetAssembly(challengeType).GetTypes().Where(TheType => TheType.IsClass && !TheType.IsAbstract && TheType.IsSubclassOf(challengeType)).ToList();
            foreach (var type in types)
            {
                if (type.IsClass)
                {
                    Console.WriteLine($"--------------Running {type.Namespace} {type.Name}-----------------------");
                    Console.WriteLine(Environment.NewLine);

                    var challenge = (Challenge)Activator.CreateInstance(type);
                }
            }
        }
    }
}

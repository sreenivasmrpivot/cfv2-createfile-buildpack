using System;
using System.Linq;

namespace supply
{
    class Program
    {
        static void Main(string[] args)
        {
            var argsWithCommand = new[] {"supply"}.Union(args).ToArray();
            Console.WriteLine("Running supply!");
        }
    }
}

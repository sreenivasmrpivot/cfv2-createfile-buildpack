using System;
using System.Linq;

namespace detect
{
    class Program
    {
        static void Main(string[] args)
        {
            var argsWithCommand = new[] {"detect"}.Union(args).ToArray();
            Console.WriteLine("Running detect!");
        }
    }
}

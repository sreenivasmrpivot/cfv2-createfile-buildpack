using System;
using System.Linq;

namespace finalize
{
    class Program
    {
        static void Main(string[] args)
        {
            var argsWithCommand = new[] {"finalize"}.Union(args).ToArray();
            Console.WriteLine("Running finalize!");
        }
    }
}

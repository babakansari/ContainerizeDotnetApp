using System;

namespace TestsInDocker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var max = args.Length != 0 ? Convert.ToInt32(args[0]) : -1;
            foreach (var countStr in Counter.RunCounter(max))
            {
                Console.WriteLine(countStr);
            }

           
        }

        
    }
}

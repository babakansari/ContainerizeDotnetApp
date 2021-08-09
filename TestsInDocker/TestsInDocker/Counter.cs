using System.Collections.Generic;
using System.Threading;

namespace TestsInDocker
{
    internal static class Counter
    {
        internal static IEnumerable<string> RunCounter(int max)
        {
            var counter = 0;
            while (max == -1 || counter < max)
            {
                //Console.WriteLine($"Counter: {++counter}");
                yield return $"Counter: {++counter}";
                Thread.Sleep(1000);
            }
        }
    }
}

using System;
using System.Threading;

namespace PlatformyWatki
{
    class Program
    {
        static void Main()
        {
            RandMatrixMultiplier m = new RandMatrixMultiplier(3);
            /*var watch = System.Diagnostics.Stopwatch.StartNew();
            Thread[] threads = new Thread[2];
            threads[0] = new Thread(m.Odd);
            threads[1] = new Thread(m.Even);
            foreach (Thread thread in threads)
                thread.Start();
            foreach (Thread thread in threads)
                thread.Join();
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("With threads: " + elapsedMs + " ms");

            watch = System.Diagnostics.Stopwatch.StartNew();
            m.Whole();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("No threads: " + elapsedMs + " ms");
            */
            m.Display();
        }
    
    }
}


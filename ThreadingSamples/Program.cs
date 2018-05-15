using System;
using System.Threading;

namespace ThreadingSamples
{
    class Program
    {
        

        static void Main(string[] args)
        {
            BackgroundThread.Start();
            StoppingAThread.Start();

            ParameterizedThread.Start();

            SimpleThread.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Main thread: {i}");
                Thread.Sleep(1000);
            }

            StoppingAThread.stopped = true;
            Console.ReadKey();
        }
    }
}

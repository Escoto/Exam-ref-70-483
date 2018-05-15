using System;

using System.Threading;

namespace ThreadingSamples
{
    class ParameterizedThread
    {
        static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine($"Parameterized Thread: {i}");
                Thread.Sleep(500);
            }
        }

        public static void Start()
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(5);
            
            //t.Join();
        }
    }
}

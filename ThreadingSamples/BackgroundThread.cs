using System;
using System.Threading;

namespace ThreadingSamples
{
    public class BackgroundThread
    {
        static void BackgroundMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Background Thread: {i}");
                Thread.Sleep(1000);
            }
        }

        public static void Start()
        {
            Thread t = new Thread(new ThreadStart(BackgroundMethod));
            t.IsBackground = true;
            t.Start();

            //We dont Join this thread because 
            //it's running on the background doing it's own thing
            //t.Join();
        }
    }
}

using System;
using System.Threading;

namespace ThreadingSamples
{
    public class SimpleThread
    {
        //This will be ran in it's own thread
        static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Simple Thread: {0}", i);
                Thread.Sleep(0);
            }
        }

        public static void Start() {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main Thread in Simple: {0}", i);
                Thread.Sleep(0);
            }

            //Join method is called on the main thread 
            //so main waits until the thread finishes
            t.Join();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadingSamples
{
    public class StoppingAThread
    {
        public static bool stopped = false;
        
        public static void Start()
        {

            Thread t = new Thread(new ThreadStart(() =>
            {
                int i = 0;
                while (!stopped)
                {
                    Console.WriteLine($"Stopping Trhead: {i}");
                    Thread.Sleep(1000);
                    i++;
                }
            }));

            t.Start();

            //We don't want to join the stoping thread 
            //because the main is going to stop it
            //once the other threads finish
            //t.Join();
        }
    }
}

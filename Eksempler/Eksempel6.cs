using System;
using System.Threading;

namespace Eksempler
{
    public class Eksempel6
    {
        //
        // FORSKELLIGE MÅDER AT STARTE TRÅDE PÅ
        //
        // ThreadStart signatur public delegate void ThreadStart();

        public void Run()
        {
            // Alternativ
            // Thread t = new Thread(Go);    // No need to explicitly use ThreadStart
            // Eller med lambda:
            // Thread t = new Thread ( () => Console.WriteLine ("Hello!") );
            Thread t = new Thread(new ThreadStart(Go));
            t.Start();   // Run Go() on the new thread.

            Go();        // Simultaneously run Go() in the main thread.
        }

        static void Go()
        {
            Console.WriteLine("hello!");
        }

    }
}
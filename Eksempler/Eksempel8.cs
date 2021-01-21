using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Eksempler
{
    public class Eksempel8
    {
        // Navne på threads.
        // kan gøre debugging nemmere
        public void Run()
        {
            Thread.CurrentThread.Name = "main";
            Thread worker = new Thread(Go);
            worker.Name = "worker";
            worker.Start();
            Go();
        }

        static void Go()
        {
            Console.WriteLine("Hello from " + Thread.CurrentThread.Name);
        }
    }
}

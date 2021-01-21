using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Eksempler
{
    public class Eksempel1
    {
        public Eksempel1()
        {
            Run();
        }
        public void Run()
        {
            Thread t = new Thread(WriteY);          // Kick off a new thread
            t.Start();                               // running WriteY()

            // Simultaneously, do something on the main thread.
            for (int i = 0; i < 1000; i++) Console.Write("x");
        }
        static void WriteY()
        {
            for (int i = 0; i < 1000; i++) Console.Write("y");
        }
    }
}

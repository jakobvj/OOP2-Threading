using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Eksempler
{
    public class Eksempel5
    {
        // Løsning på eksempel 4, med exclusive lock
        // thread-safe
        static bool done;
        static readonly object locker = new object();
        public void Run()
        {
            new Thread(Go).Start();
            Go();
        }
        static void Go()
        {
            // her vil den ene tråd vente på den anden frigiver lock´en
            lock (locker)
            {
                if (!done) { Console.WriteLine("Done"); done = true; }
            }
        }
    }
}

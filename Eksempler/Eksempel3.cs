using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Eksempler
{
    public class Eksempel3
    {
        bool done;

        public void Run()
        {
            Eksempel3 tt = new Eksempel3();   // Create a common instance
            new Thread(tt.Go).Start();
            tt.Go();
        }
        // Note that Go is now an instance method
        // Derfor deler de "done"
        void Go()
        {
            if (!done) { done = true; Console.WriteLine("Done"); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Eksempler
{
    public class Eksempel4
    {
        // vha af statiske variabler kan resourcer deles
        // viser hvorfor thread safety er vigtigt!
        static bool done;

        public void Run()
        {
            new Thread(Go).Start();
            Go();
        }
        // kan i princippet udskrives to gange
        static void Go()
        {
            if (!done) { done = true; Console.WriteLine("Done"); }
        }
        //static void Go()
        //{
        //    if (!done) { Console.WriteLine("Done"); done = true; }
        //}
    }
}

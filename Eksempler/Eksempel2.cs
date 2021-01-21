using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Eksempler
{
    class Eksempel2
    {
        public Eksempel2()
        {
            Run();
        }
        public void Run()
        {
            new Thread(Go).Start();      // Call Go() on a new thread
            Go();
        }
        static void Go()
        {
            // Declare and use a local variable - 'cycles'
            // Bliver lavet for hver tråds memory stack. Derfor ikke samme cycles variabel
            for (int cycles = 0; cycles < 5; cycles++) Console.Write('?');
        }
    }
}

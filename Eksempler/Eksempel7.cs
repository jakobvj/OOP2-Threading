using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Eksempler
{
    public class Eksempel7
    {
        // Sende data til Thread

        #region Nemmeste måde er en lambda der sender med til den metode der bliver kaldt
        //public void Run()
        //{
        //    Thread t = new Thread(() => Print("Hello from t!"));
        //    t.Start();
        //}

        //static void Print(string message)
        //{
        //    Console.WriteLine(message);
        //}
        #endregion

        #region Sende med til Threads start metode
        // Det kan lade sig gøre da constructoren til en thread kan modtage:
        //public delegate void ThreadStart();
        //public delegate void ParameterizedThreadStart(object obj);
        // Det betyder der også kun kan komme én parameter med, og oftes må castes
        public void Run()
        {
            Thread t = new Thread(Print);
            t.Start("Hello from t!");
        }

        static void Print(object messageObj)
        {
            string message = (string)messageObj;   // We need to cast here
            Console.WriteLine(message);
        }
        #endregion
    }
}

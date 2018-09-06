﻿using System;

namespace _01ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //a két alkalmazás modul, ami igényt tart az információra
            //ők a megfigyelők: (Observers)

            //naplózás
            var log = new Logger();
            //és felhasználói felület
            var ui = new UserInterface();

            //a hosszantartó folyamatunk
            var process = new LongRunningProcess();

            process.ObserversCallList += log.Message;
            process.ObserversCallList += ui.Message;

            process.Start();

            process.ObserversCallList -= log.Message;
            process.ObserversCallList -= ui.Message;

            Console.WriteLine("A folyamat lefutott");

            Console.ReadLine();
        }
    }
}

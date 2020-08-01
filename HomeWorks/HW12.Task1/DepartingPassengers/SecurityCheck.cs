using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace HW12.Task1
{
    class SecurityCheck : DepartingPassengers
    {
        public Person person;
        public string phrase;
        public string suspisiosphrase;
        public bool hasdangerousthings;
        public SecurityCheck(Person p, bool _hasdangerousthings)
            {
            person = p;
            hasdangerousthings = _hasdangerousthings;
            }

        public void CheckPassenger()
        {
            string phrase;
            
            Console.WriteLine("Please put out all electronics in a corb and go throgh the metall detactor");
            Thread.Sleep(4000);

            if (hasdangerousthings.Equals(false))
            {
                phrase = "You're fine, please proceed";
                Console.WriteLine("You're fine, please proceed");
                Thread.Sleep(1000);
            }
            else
            {
                phrase = "Please proceed to the police room";
                Console.WriteLine("Please proceed to the police room");
                Thread.Sleep(1000);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HW12.Task1
{
    class PassportControl:DepartingPassengers
    {

        public void CheckPassport( Person person, out bool validvisa  )
        {
            Console.WriteLine("Show your passport please");
            Thread.Sleep(1000);
            Console.WriteLine("Do you have a visa?");
            Thread.Sleep(1000);
            string answer = Console.ReadLine();
            if (answer.Equals("yes"))
            {
                validvisa = true;
                Console.WriteLine("Have as nice flight!");
                Thread.Sleep(1000);
            }
            else
            {
                validvisa = false;
                Console.WriteLine("You can't fly without visa");
            }
        }
    }
}

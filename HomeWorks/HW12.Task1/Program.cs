using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace HW12.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person2 = new Person() { Name = "Mila", Lastname = "Dofi", Baggagetocheckin = false };
            Person person3 = new Person() { Name = "Ales", Lastname = "Saanchez", Baggagetocheckin = true };
            Person person4 = new Person() { Name = "Vanya", Lastname = "Frolov", Baggagetocheckin = false };

            CheckIn.Greeting("evening", out CheckIn.passengeranswername);
            Person person1 = new Person();
            CheckIn.AskPassengerInfoBoardingPass(CheckIn.passengeranswername, out bool ischeckedinvalue);
            person1.Ischeckedin = ischeckedinvalue;
            CheckIn.AskPassengerInfoBaggage(CheckIn.passengeranswername, out bool hasregisteredbaggevalue);
            person1.Baggagetocheckin = hasregisteredbaggevalue;

            if (person1.Ischeckedin.Equals(false) && (person1.Baggagetocheckin.Equals(true)))
            {
                CheckIn.GiveBoardingPass(person1, person1.Ischeckedin);
                CheckIn.RegisterBaggage(person1, person1.Baggagetocheckin);
                Console.WriteLine("Please proceed to the Securitycheck");
                Thread.Sleep(1000);
            }
            else if (person1.Ischeckedin.Equals(false))
            {
                CheckIn.GiveBoardingPass(person1, person1.Ischeckedin);
                Console.WriteLine("Please proceed to the Securitycheck");
                Thread.Sleep(1000);
            }
            else if(person1.Baggagetocheckin.Equals(true))
            {
                CheckIn.RegisterBaggage(person1, person1.Baggagetocheckin);
                Console.WriteLine("Please proceed to the Securitycheck");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Please proceed to the Securitycheck");
                Thread.Sleep(1000);
            };

            SecurityCheck p1security = new SecurityCheck(person1, false);
            p1security.CheckPassenger();

            if (p1security.hasdangerousthings.Equals(false))
            {
                PassportControl p1passport = new PassportControl();
                p1passport.CheckPassport(person1, out bool validvisa);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace HW12.Task1
{
    class CheckIn:Answer
    {
        static CheckIn()
        {
            int UserID = 0;
            UserID++;
        }
        public static void CheckInpassenger()
        {
            Console.WriteLine("Have you check-in online?");
            string AnswerCheckIn = Console.ReadLine();

            Console.WriteLine("Do you have a baggage that must be registered?");
            string AnswerPassportControl=CheckInAnswer.AnswerPassportControl;

            switch (AnswerPassportControl)
            {
                case "yes":
                    Console.WriteLine("Give your passport please");
                    break;
                case "no":
                    Console.WriteLine("Give your passport and flightticket please");
                    break;

                    public class CheckInAnswer : Answer
        {
            public static string AnswerPassportControl;
            public static string AnswerBag;
            public void AskPassport()
            {

                Console.WriteLine("Have you passed Check-In?");
                AnswerPassportControl = Console.ReadLine();
                Console.WriteLine("Do you have a baggage that must be registered?");
                AnswerBag = Console.ReadLine();

                switch ()
                {
                    case "yes":
                        Console.WriteLine("Give your passport please");
                        break;
                    case "no":
                        Console.WriteLine("Have a nice flight!");
                        break;
                }
            }
        }
    }
}
   

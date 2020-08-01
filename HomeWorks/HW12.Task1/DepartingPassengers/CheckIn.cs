using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;

namespace HW12.Task1
{
    class CheckIn : DepartingPassengers

    {
        public static string passengeranswername;
        public static string Passengeranswername { get; set; }
        
        public static void  Greeting(string partoftheday, out string passengeranswername)
        {
            if (partoftheday.Equals("morning"))
            {
                Console.WriteLine("Good Morning! What is your Name?");
            }
            else if (partoftheday.Equals("day"))
            {
                Console.WriteLine("Good Day! What is your Name?");
            }
            else
            {
                Console.WriteLine("Good Evening! What is your Name?");
            }
            passengeranswername = Console.ReadLine();

        }

        public static void AskPassengerInfoBoardingPass(string passengeranswername, out bool  ischeckedin)
        {
            Console.WriteLine($"{passengeranswername}, did you pass checkin?");

            if (Console.ReadLine().Equals("yes"))
                { ischeckedin = true; }
            else
            { ischeckedin = false; };

        }
        public static void AskPassengerInfoBaggage(string passengeranswername, out bool Baggagetocheckin)
        {
            Console.WriteLine($"{passengeranswername}  Do you have baggage to register?");
            Thread.Sleep(1000);

            if (Console.ReadLine().Equals("yes"))
            { Baggagetocheckin = true; }
            else
            { Baggagetocheckin = false; };

        }
        public static void GiveBoardingPass(Person person,  bool ischeckedin)
        {
            if(ischeckedin.Equals(false))
            {
                Console.WriteLine($"Have your boarding pass please.");
                Thread.Sleep(1000);
            }
        }
        public static void RegisterBaggage(Person person, bool Baggagetocheckin)
        {
            if (Baggagetocheckin.Equals(true))
            {
                Console.WriteLine("Please give your bag");
                Thread.Sleep(1000);
            }
        }
    }
}

   

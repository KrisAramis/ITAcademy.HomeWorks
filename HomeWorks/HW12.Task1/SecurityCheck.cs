using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HW12.Task1
{
    class SecurityCheck:Answer
    {
        public string SecurityControl;
        //проверяем багаж
        public static void Checkbags()
        {   
            switch (SecurityControl)
            {
                case "Clean":
                    Console.WriteLine("Please move to the Registration Desk");
                    break;
                case "Drugs":
                    Console.WriteLine("Please go to the security room with us.");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Text;

namespace AssamblyOne
{
    public class MotorcyclePublic
    {
        string  Manufacturer = "Yamaha";
        string vinNumber = "34ERU423-33ER-TYUI-234234098DS3";
        string enginePower = "230HP";
        static void Countmileage ()
        {
            Console.WriteLine("This is privat class");
        }

        public static void CalculatepricePublic()
        {
            Console.WriteLine("This is public class");
            Countmileage();
            Updateowner(); 
        }

        protected static void Updateowner() 
        {
            Console.WriteLine("This is a protected class");
        }

        protected internal void UpdateownerProtectedInternal()
        {
            Console.WriteLine("This is a protected interal method");
        }

        public class Bicycle : MotorcyclePublic
        {
            public static void AddInfo()
            {
                CalculatepricePublic();
                Updateowner();
                Countmileage(); 
            }
        }

        public class Boat
        {
            public static void AddBoat()
            {
                CalculatepricePublic();
                Updateowner();
            }
        }
        
        public class New
        {
            public void Newmethod()
            {
            MotorcyclePublic BMW = new MotorcyclePublic();
            BMW.UpdateownerProtectedInternal(); //protected internal can be accessed by a class in same file
            }
        }
    }
}

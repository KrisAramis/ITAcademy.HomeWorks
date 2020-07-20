using System;
using System.Collections.Generic;
using System.Text;

namespace HW9.Task2
{
    public class SmallAppartment : House
    {
        public SmallAppartment()
           : base(50)
        {

        }
        public void ShowData()
        {
            Console.WriteLine($"Your appartment is {area} m2.");
        }
    }
}

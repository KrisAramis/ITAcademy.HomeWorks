using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace HW9.Task2
{
    class House
    {
         double area { get; set; }
            
        public void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {area} m2");
        }

        public void GetDoor()
        {

        }
    }
}

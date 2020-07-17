using System;
using System.Collections.Generic;
using System.Text;

namespace HW9.Task2
{
    class Door:House
    {
        string color { get; set; }
        public void ShowData()
        {
            Console.WriteLine($"I am a door, my color is {color}");
        }
    }
}

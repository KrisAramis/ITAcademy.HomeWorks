using System;
using System.Collections.Generic;
using System.Text;

namespace HW9.Task2
{
    public class Door
    {
        protected string color;
        
        public Door()
        {
            color = "Brown";
        }
        public string Color
        {
            get => color;
            set => color = value;
        }

        public Door (string color)
        {
            this.color = color;
        }
        public void ShowData()
        {
            Console.WriteLine($"I am a door, my color is {color}");
        }
    }
}

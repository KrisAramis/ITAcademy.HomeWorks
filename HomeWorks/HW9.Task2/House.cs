using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;

namespace HW9.Task2
{
    public class House
    {
        protected double area;
        protected Door door;
        public House (double area)
        {
            this.area = area;
            door = new Door();
        }

        public double Area
        {
            get =>  area;
            set => area=value;
        }

        public Door Door
        {
            get =>  door;
            set => door = value;
        }

        public void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {area} m2");
        }
    }
}

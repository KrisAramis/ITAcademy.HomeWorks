using System;
using System.Collections.Generic;
using System.Text;

namespace HW9.Task2
{
    class Person
    {
        protected House house;
        
        protected string name;
        public Person(string name, House house)
        {
            name = "Julian";
            house = new House(200);
        }

        public Person()
        {
            this.name = name;
            this.house = house;
        }

        public string Name
        {
            get  => name; 
            set => name = value; 
        }

        public House House
        {
            get => House;
            set => house = value;
        }
     public void ShowData()
        {
            Console.WriteLine($"Person's name is {name}");
            house.ShowData();
            house.Door.ShowData();
        }
    }
}

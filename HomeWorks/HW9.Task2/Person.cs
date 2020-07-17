using System;
using System.Collections.Generic;
using System.Text;

namespace HW9.Task2
{
    class Person
    {
        public string Name;
        public double house;
        public Person()
        { house = 1}

        public void ShowData()
        {
            Console.WriteLine($"{Name} has a {House.area} house with {Door.name} door")
        }
//         Each person will have a house.
//The method "ShowData" for a person will display his/her name, show the data
//of his/her house and the data of the door of that house.
//• Write a Main to create a SmallApartment, a person to live
    }
}

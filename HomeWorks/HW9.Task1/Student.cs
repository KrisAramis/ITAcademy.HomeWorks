using System;
using System.Collections.Generic;
using System.Text;

namespace HW9.Task1
{
    class Student:Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class");
        }

        public void ShowAge()
        {
            Console.WriteLine($"Hello, I'm {age} years old");
        }
    }
}

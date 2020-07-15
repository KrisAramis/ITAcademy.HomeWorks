using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace HW9.Task1
{
    class Person
    {
        public int age;
        public string name;

        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
        public void SetAge (int n)
        {
            age = n;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace HW9.Task1
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person Vasya = new Person();
            Vasya.Greet();
            Student Petya = new Student();
            Petya.SetAge(21);
            Petya.Greet();
            Petya.ShowAge();
            Teacher Volha = new Teacher();
            Volha.SetAge(30);
            Volha.Greet();
            Volha.Explain();
        }
    }
}

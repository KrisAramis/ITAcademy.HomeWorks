using System;
using System.Collections.Generic;
using System.Text;

namespace HW03.Task1
{
    public class Calculator
    {
        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Substraction(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Multiplication(int x, int y)
        {
            return x * y;
        }
        public  int Devision(int x, int y)
        {
            return x / y;
        }
        public int DevisionReminder(int x, int y)
        {
            return x % y;
        }
        public double CircleArea(double radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }

}

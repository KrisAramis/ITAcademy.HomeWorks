using System;
using System.Collections.Generic;
using System.Text;

namespace HW03.Task1
{
    class Calculator
        {
            public static int Sum(int x, int y)
            {
            return x + y;
            }
              public static int Subtraction(int x, int y)
            {
            return x -y;
            }
            public static int Multiplication(int x, int y)
            {
                return x*y;
            }
            public static int Devision(int x, int y)
            {
                return x/y;
            }
            public static int DevisionReminder(int x, int y)
            {
                return x % y;
            }
            public static double CircleArea(double radius)
            {
                return Math.Pow(radius, 2) *Math.PI;
            }
    }
}




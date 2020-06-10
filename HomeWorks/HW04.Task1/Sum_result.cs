using System;
using System.Collections.Generic;
using System.Text;

namespace HW04.Task1
{
    class Sum_result
    {
        public static int  Sum_ordinary()
        {
            Console.WriteLine("Input 1st number:");
             int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2nd number:");
             int num2 = Convert.ToInt32(Console.ReadLine());
            return num1 + num2;
        }
    }
     
}

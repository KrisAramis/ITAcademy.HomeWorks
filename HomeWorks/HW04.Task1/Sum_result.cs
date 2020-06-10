using  System;
using System.Collections.Generic;
using System.Text;

namespace HW04.Task1
{
    class Sum_result
    {
        public void  Sum_askuser()
        {
            Console.WriteLine("Input 1st number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2nd number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input sum of this numbers:");
            int userinput = Convert.ToInt32(Console.ReadLine());
            int result = num1 + num2;
           
            if (userinput==result)
            {
                Console.WriteLine($"{result} is the right answer");
            }
            else
            {
                Console.WriteLine($"{result} is the wrong answer");
            }
        }
    }
}

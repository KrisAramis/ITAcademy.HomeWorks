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
            Console.WriteLine("Input the operator: \"+\" or \"-\"");
            string operatoris = Console.ReadLine();
            int result = 0;
            switch (operatoris)
            {
                case "+":
                     result = num1 + num2;
                    break;
                case "-":
                     result = num1 - num2;
                    break;
            }

            Console.WriteLine("Input the answer:");
            int userinput = Convert.ToInt32(Console.ReadLine());

            if (userinput==result)
            {
                Console.WriteLine($"{userinput} is the right answer");
            }
            else
            {
                Console.WriteLine($"{userinput} is the wrong answer");
                    if (userinput > result)
                    Console.WriteLine("Number should be lower");
                    else
                    {
                    Console.WriteLine("Number should be higher");
                    }
            }
        }
    }
}

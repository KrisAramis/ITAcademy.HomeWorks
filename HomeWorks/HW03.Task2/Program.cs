using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


namespace HW03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Сложение двух чисел(два входных параметра)
            Console.WriteLine("Сложение двух чисел(два входных параметра):");
            Console.WriteLine("Input 1st number:");
            int var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2nd number:");
            int var2 = Convert.ToInt32(Console.ReadLine());
            int sum = Calculator.Sum(var1, var2);
            Console.WriteLine("Result equals:{0}", sum);

            //2.Вычитание двух чисел(два входных параметра)
            Console.WriteLine("Вычитание двух чисел(два входных параметра):");
            Console.WriteLine("Input 1st number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2nd number:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int subtraction = Calculator.Subtraction(number1, number2);
            Console.WriteLine("Result equals:{0}", subtraction);

            //3.Умножение двух чисел(два входных параметра)
            Console.WriteLine("Умножение двух чисел(два входных параметра):");
            Console.WriteLine("Input 1st number:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2nd number:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int multiplication = Calculator.Multiplication(input1, input2);
            Console.WriteLine("Result equals:{0}", multiplication);

            //4.Деление двух чисел(два входных параметра)
            Console.WriteLine("Деление двух чисел(два входных параметра):");
            Console.WriteLine("Input 1st number:");
            int variable1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2nd number:");
            int variable2 = Convert.ToInt32(Console.ReadLine());
            int devision = Calculator.Devision(variable1, variable2);
            Console.WriteLine("Result equals:{0}", devision);

            //5.Остаток от деления(два входных параметра)
            Console.WriteLine("Остаток от деления(два входных параметра):");
            Console.WriteLine("Input 1st number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2nd number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int DevisionReminder = Calculator.DevisionReminder(num1, num2);
            Console.WriteLine("Result equals:{0}", DevisionReminder);

            //6.Площадь круга(один входной параметр)
            Console.WriteLine("Площадь круга(один входной параметр):");
            Console.WriteLine("Input radius:");
            double radius = Convert.ToDouble(Console.ReadLine());
            double CircleArea = Calculator.CircleArea(radius);
            Console.WriteLine("Result equals:{0}", CircleArea);
        }
    }
}
            
              
        

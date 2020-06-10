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

            Calculator getsum = new Calculator();
            int result = getsum.Sum(var1, var2);
            Console.WriteLine("Result equals:{0}", result);

            //2.Вычитане двух чисел(два входных параметра)
            Console.WriteLine("Вычитание двух чисел(два входных параметра):");
            Console.WriteLine("Input 1st number:");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2nd number:");
            
            int numb2 = Convert.ToInt32(Console.ReadLine());

            Calculator getsubstraction = new Calculator();
            int resultminus = getsubstraction.Substraction(numb1, numb2);
            Console.WriteLine("Result equals:{0}", resultminus);

            //4.Деление двух чисел(два входных параметра)
            Console.WriteLine("Деление двух чисел(два входных параметра):");
            Console.WriteLine("Input 1st number:");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2nd number:");
            int input2 = Convert.ToInt32(Console.ReadLine());

            Calculator getdeviion = new Calculator();
            int resultdevide = getsubstraction.Devision(input1, input2);
            Console.WriteLine("Result equals:{0}", resultdevide);

            //5.Остаток от деления(два входных параметра)
            Console.WriteLine("Остаток от деления(два входных параметра):");
            Console.WriteLine("Input 1st number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2nd number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Calculator getreminder = new Calculator();
            int resultreminder = getreminder.DevisionReminder(num1, num2);
            Console.WriteLine("Result equals:{0}", resultreminder);

            //6.Площадь круга(один входной параметр)
            Console.WriteLine("Площадь круга(один входной параметр):");
            Console.WriteLine("Input 1st number:");
            double radius = Convert.ToDouble(Console.ReadLine());

            Calculator getarea = new Calculator();
            double resultarea = getarea.CircleArea(radius);
            Console.WriteLine("Result equals:{0}", resultarea);
       }
    }
}
            
              
        

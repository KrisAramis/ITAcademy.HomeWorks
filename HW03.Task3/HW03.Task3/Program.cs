using System;

namespace HW03.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Введите год рождения");
            int yearbirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц рождения числом");
            int monthbirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите настоящий год");
            int yeartoday = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите настоящий месяц");
            int monthtoday = Convert.ToInt32(Console.ReadLine());
            if (monthtoday >= monthbirth)
            {
                int age = yeartoday - yearbirth;
                Console.WriteLine("Возраст:{0}", age);
            }
            else
            {
                int age = yeartoday - yearbirth - 1;
                Console.WriteLine("Возраст:{0}", age);
            }
        }
    }
}

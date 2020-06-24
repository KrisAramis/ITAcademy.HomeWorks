using System;
using System.Collections.Generic;
using System.Text;

namespace HW06.Task1
{
    public class ReturnFormattedPoem
    {
        public static string Askpoem()
        {
            Console.WriteLine("Input a poem by separating lines with semicolon:");
            string InputPoem = Console.ReadLine();
            return InputPoem;
        }
        public static void  Replaceletters(string InputPoem)
        {
                string modifiedInputPoem;
                modifiedInputPoem = InputPoem.Replace('s', 'a').Replace('a','s');
                Console.WriteLine(modifiedInputPoem);
        }
        public static void SeparatePoem(string Inputpoem)
        {
            string[] poem = Inputpoem.Split(';');
            foreach (String s in poem)
            Console.WriteLine(s);
        }
    }
}

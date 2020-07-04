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
        public static string  Replaceletters(string poem)

        {
            string modifiedInputPoem;
            modifiedInputPoem = poem.Replace('o','a');
            return modifiedInputPoem;
        }
        public static void SeparatePoem(string modifiedinput)
        {
            string[] modifiedinpurarray = new string[] { };
            modifiedinpurarray = modifiedinput.Split(';');
            foreach (string s in modifiedinpurarray) 
            { 
                Console.WriteLine($"\n{s}");
            }
        }
    }
}

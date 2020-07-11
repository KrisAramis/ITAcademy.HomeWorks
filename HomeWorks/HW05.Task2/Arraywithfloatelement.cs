using System;
using System.Collections.Generic;
using System.Text;

namespace HW05.Task2
{
    public class Arraywithfloatelement
    {
        public static void Arrayfloat()
        {
            const int arraylength = 10;
            int[] arraywithoutfloatelement = new int[arraylength];
            int[] arraywithfloatelement = new int[arraylength];
            for (int i = 0; i < arraywithoutfloatelement.Length - 1; i++)
            {
                Console.WriteLine("Input number:");
                arraywithoutfloatelement[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arraylength; i++)
            {
                Console.WriteLine($"arraywithoutfloatelement[{i}]:{arraywithoutfloatelement[i]}");
            }

            Console.WriteLine("Input the position for new element:");
            int elementposition = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the value of the new element:");
            int elementvalue = Convert.ToInt32(Console.ReadLine());
            arraywithfloatelement[elementposition] = elementvalue;
            int lengthafterfloat = arraylength - elementposition;
            arraywithfloatelement[elementposition] = elementvalue;
            Array.Copy(arraywithoutfloatelement, elementposition, arraywithfloatelement, elementposition + 1, lengthafterfloat - 1);
            Array.Copy(arraywithoutfloatelement, arraywithfloatelement, elementposition);

            for (int i = 0; i < arraylength; i++)
            {
                Console.WriteLine($"arraywithfloatelement[{i}]:{arraywithfloatelement[i]}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HW05.Task1
{
    public class Twoarrays
    {
        public static void Twoarraysum()
        {
            const int arraylength = 10;
            int[] randomarray = new int[arraylength];
            Random rundomgenerator = new Random();

            for (int i = 0; i < randomarray.Length; ++i)
            {
                randomarray[i] = rundomgenerator.Next(1, 100);
            }

            int[] fromconsolearray = new int[arraylength];
            Console.WriteLine("Input number:");
            for (int i = 0; i < arraylength; i++)
            {
                fromconsolearray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] sumarray = new int[arraylength];
            for (int i = 0; i < sumarray.Length; i++)
            {
                sumarray[i] = fromconsolearray[i] + randomarray[i];
            }
            for (int i = 0; i < arraylength; i++)
            {
                Console.WriteLine($"fromconsolearray[{i}]: {fromconsolearray[i]}");
                Console.WriteLine($"randomarray[{i}]: {randomarray[i]}");
                Console.WriteLine($"sumarray[{i}]:{sumarray[i]}");
            }
        }
    }
}

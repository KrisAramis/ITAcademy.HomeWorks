using System;

namespace HW05.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int arraylength = 10;
            int[] randomarray = new int [arraylength];
            Random rundomgenerator = new Random();

            for (int i=0; i< randomarray.Length; ++i)
            {
                randomarray[i] = rundomgenerator.Next(1, 100);
            }

            int[] fromconsolearray = new int[arraylength];
            Console.WriteLine("Input number:");
            for (int i = 0; i<arraylength; i++)
                {
                fromconsolearray[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(fromconsolearray[i]);

            }

            int[] sumarray = new int[arraylength];
            for (int i = 0; i< sumarray.Length;i++)
            {
                sumarray[i] = fromconsolearray[i] + randomarray[i];
                    
            }
            for(int i =0; i<arraylength; i++)
            {
                Console.WriteLine("{0} member of {1}: {2}", i, fromconsolearray, fromconsolearray[i]);
                Console.WriteLine("{0} member of {1}: {2}", i, randomarray, randomarray, randomarray[i]);
                Console.WriteLine("{0} member of {1}: {2}", i, sumarray, sumarray[i]);
            }
            
        }
    }
}

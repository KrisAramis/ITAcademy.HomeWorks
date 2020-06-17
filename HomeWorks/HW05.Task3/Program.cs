using System;

namespace HW05.Task3
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] reversearray = new int [] {1, 2, 3, 4, 5, 6, 7};
            Array.Reverse(reversearray);
            foreach(var i in reversearray)
            {
                Console.WriteLine($"reversearray[{i-1}]:{reversearray[i-1]}");
            }
        }
    }
}

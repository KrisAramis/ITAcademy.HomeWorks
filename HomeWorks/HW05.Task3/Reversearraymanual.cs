using System;
using System.Collections.Generic;
using System.Text;

namespace HW05.Task3
{
    public class Reversebymyself
    {
        public static void Reversearraymanual()
        {
            int[] arraybeforereverse = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            foreach (var i in arraybeforereverse)
            {
                Console.WriteLine($"reversearray[{i - 1}]:{arraybeforereverse[i - 1]}");
            }
            
            int[] arrayafterreverse = new int[7];
            for (int i = arraybeforereverse.Length; i >= 1; i--)
            {
                arrayafterreverse[arraybeforereverse.Length - i] = arraybeforereverse[i - 1];
            }
            for (int i = 0; i < arrayafterreverse.Length; i++)
            {
                Console.WriteLine($"arrayafterreverse[{i}]:{arrayafterreverse[i]}");
            }
        }
    }
}

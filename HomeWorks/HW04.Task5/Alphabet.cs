using System;
using System.Collections.Generic;
using System.Text;

namespace HW04.Task5
{
    class Alphabet
    {
        public  void alphareverse()
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for (int i = alpha.Length - 1; i<alpha.Length && i >= 0; i--)
            {
                Console.WriteLine(alpha[i]);
}
        }
    }
}

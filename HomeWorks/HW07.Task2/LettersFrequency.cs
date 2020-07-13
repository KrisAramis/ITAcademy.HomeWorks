using System;
using System.Collections.Generic;
using System.Text;

namespace HW07.Task2
{
    sealed class LettersFrequency
    {
        public void CountLettersFrequency()
        {
            string str;
            int i, cnt;
            char [] finaloutput = new char[] { };
            Console.WriteLine("Enter a sentence");
            str = Console.ReadLine();
            char ch;
            
                for (ch = (char)65; ch <= 90; ch++)
                {
                    cnt = 0;
               
                    for (i = 0; i < str.Length; i++)
                    {

                        if (ch == str[i] || (ch + 32) == str[i])
                        {
                            cnt++;
                        }
                    }
                    if (cnt > 0)    
                    {
                        Console.WriteLine(ch + "=" + cnt);
                    }
                }
            }
    }
}

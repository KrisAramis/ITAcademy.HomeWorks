using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace HW06.Task2
{
    public class Actionswithstring
    {
        public static void Deletelongestword(string stringexample)
        {
            string longestword = "yes";
            string[] stringwords = stringexample.Split(" ");
            for (int i = 0; i < stringwords.Length; i++)
            {
                int max = stringwords[0].Length;
                if (stringwords[i].Length >= max)
                    longestword = stringwords[i];
            }
            Console.WriteLine($"{longestword} is the longest word");
            string newstringexample = stringexample.Replace(longestword, "");
            Console.WriteLine($"Initial String:{stringexample} \nString after THE_LONGEST_WORD_DELETED: {newstringexample}");
        }

        public static void Replacelongwithshort(string stringexample)
        {
            string longestword = "yes";
            string[] stringwords = stringexample.Split(" ");
            string shortestword = "d";
            for (int i = 0; i < stringwords.Length; i++)
            {
                int max = stringwords[0].Length;
                if (stringwords[i].Length >= max)
                    longestword = stringwords[i];
            }
            for (int i = 0; i < stringwords.Length; i++)
            {
                int min = stringwords[0].Length;
                if (stringwords[i].Length <= min)
                    shortestword = stringwords[i];
            }
            string changedstrexample = stringexample.Replace(shortestword, longestword);
            Console.WriteLine($"Initial String:{stringexample} \nString after THE_LONGEST_WITH_SHORTEST_REPLACED: {changedstrexample}");
        }
        public static void Letterssymbolscount(string stringexample)
        {
            int letters = 0;
            int symbols = 0;
            char[] examplechars = stringexample.ToCharArray();
            for (int i = 0; i < examplechars.GetUpperBound(0); i++)
            {
                if ((examplechars[i] >= 'a' && examplechars[i] <= 'z' ) || (Char.IsUpper(examplechars[i])==true))
                {
                    letters++;
                }
                else if (Char.IsPunctuation(examplechars[i]) == true)
                {
                    symbols++;
                }
            }
            Console.WriteLine("Number of Alphabets in the string is : {0}\n", letters);
            Console.WriteLine("Number of Digits in the string is : {0}\n", symbols);
        }
    
        public static void Sortbylongestfirst(string stringexample)
        { 
            string[] stringarray = stringexample.Split(" ");
            SortAlphabetLength sorting = new SortAlphabetLength();
            Array.Sort(  stringarray, 0, stringarray.GetUpperBound(0), sorting);
            Console.WriteLine(" Sorted by the longest first: \n");
                for (int i = stringarray.GetLowerBound(0); i <= stringarray.GetUpperBound(0);i++)
                {
                    Console.WriteLine(" [{0}] : {1}", i, stringarray[i]);
                }
        }
    }
}

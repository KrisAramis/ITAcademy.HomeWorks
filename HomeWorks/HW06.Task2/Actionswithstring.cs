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
            Console.WriteLine(newstringexample);
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
            Console.WriteLine(changedstrexample);
        }
        //public static void Letterssymbolscount(string stringexample)
        //{
        //    string stringexample;
        //    char[] stringelements = stringexample.ToCharArray();
        //    string letters = "ABCDEFGHIGKLMNOPQRSTUVWXYZ";
        //    char[] alphabet = letters.ToCharArray();
        //    alphabet.R
        //    for (int i= 0; i<stringexample.Length; i++ )
        //    {
        //        if stringexample[i].CompareTo() 
        //    }
//        public static void Sortbylongestfirst(string examplestring)
//        {
//            string[] stringarray = examplestring.Split(" ");
//            int[] stringarraylength = new int[] { };
//            for (int i=0; i<=stringarray.Length-1; i++)
//            {
//                stringarraylength[i] = stringarray[i].Length;
//                Console.WriteLine(stringarraylength[i]);
//            }
            
//            Array.Sort(stringarray[i].Length);
//            for (int i= 0; i< stringarray.Length-1;i++)
//            {
//                Console.WriteLine(stringarray[i]);
//                for (int i = stringarray.GetLowerBound(0); i <= arr.GetUpperBound(0);
//           i++)
//                {
//                    Console.WriteLine("   [{0}] : {1}", i, string[i]);
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}

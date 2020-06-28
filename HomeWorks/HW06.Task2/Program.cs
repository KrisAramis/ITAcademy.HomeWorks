using System;
using System.Linq;

namespace HW06.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Examplestring = "Some string example to learn staff about strings in c#";
            Actionswithstring.Deletelongestword(Examplestring);
            Actionswithstring.Replacelongwithshort(Examplestring);
            //Actionswithstring.Letterssymbolscount(Examplestring);
            Actionswithstring.Sortbylongestfirst(Examplestring);
        }
    }
}

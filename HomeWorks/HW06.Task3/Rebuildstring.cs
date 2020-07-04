using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace HW06.Task3
{
    public class ChangeString
    {
        public static void Rebuildstring(string example)
        {
            char changepointsymbol = '?';
            int indexOfChar = example.IndexOf(changepointsymbol);
            StringBuilder changedstring = new StringBuilder();
            changedstring.Append(example);
            changedstring.Replace(' ', '_', indexOfChar, example.Length-1- indexOfChar);
            changedstring.Replace("!","", 0,indexOfChar).Replace(".", "", 0, indexOfChar);
            Console.WriteLine(indexOfChar);
            Console.WriteLine(changedstring);
        }
    }
}

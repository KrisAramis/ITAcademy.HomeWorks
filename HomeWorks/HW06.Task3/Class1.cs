using System;
using System.Collections.Generic;
using System.Text;

namespace HW06.Task3
{
    public class Rebuild
    {
        public static void Rebuildstring(string sringexample)
        {
            //        Дана символьная строка, содержащая хотя бы один символ '?'. Удалить все символы '!' или '.',
            //расположенные до первого символа '?' и заменить все пробелы, расположенные за первым
            //символом '?', на символ подчёркивания '_'.
            //Исходная строка: “1a!2.3!!.. 4.!.?6 7! ..?”
            //В данной задаче используйте StringBuilder.
            string stringexample;

            StringBuilder Examplestring = new StringBuilder();

            Examplestring.Replace("!", "6");
            Console.WriteLine(Examplestring);
        }
    }
}

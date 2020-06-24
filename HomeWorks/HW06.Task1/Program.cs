using System;
using System.Security.Cryptography.X509Certificates;

namespace HW06.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Inputpoem = ReturnFormattedPoem.Askpoem();
            ReturnFormattedPoem.Replaceletters(Inputpoem);
        }
    }
}

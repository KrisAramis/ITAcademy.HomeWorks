using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace HW12.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle yamaha = new Motorcycle() { ID = 1, Model = "Jamaha", Productionyear = "2000" };

            MotorcycleArrayRepository aa = new MotorcycleArrayRepository();
            aa.Create(yamaha);
        }
    }
}

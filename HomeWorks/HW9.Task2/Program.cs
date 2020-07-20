using System;

namespace HW9.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallAppartment Jercy = new SmallAppartment();
            Person John = new Person ();
            John.Name = "John";
            John.House = Jercy;
            Jercy.Door.Color = "green";
            John.ShowData();
        }
    }
}

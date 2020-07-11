using System;
using AssamblyOne;

namespace AssambleyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //motorcycle can't access class Motorcycle, when it doesn't have modifier public
            MotorcyclePublic.CalculatepricePublic(); // can access the public method of a public class
        }

        public class Limo : MotorcyclePublic
        {
            protected internal void SetPrice()
            {
                UpdateownerProtectedInternal(); // protected internal can be accessed in the derived class
            }
        }
    }
}

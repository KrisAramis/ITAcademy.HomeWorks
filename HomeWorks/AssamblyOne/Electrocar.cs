using System;
using System.Collections.Generic;
using System.Text;

namespace AssamblyOne
{
     //public static class Electrocar:Motorcycle static class can't be derived
     public class Electrocar:MotorcyclePublic
    {
        public void ViewAccess()
        {
            Updateowner();
            //Countmileage();
            CalculatepricePublic();
        }
    }
}

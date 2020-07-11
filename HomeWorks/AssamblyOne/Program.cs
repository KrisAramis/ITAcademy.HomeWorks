using System;
using System.Reflection.Metadata.Ecma335;

namespace AssamblyOne
{
    class InternalClass
    {

    }
    ////public class NewClass:InternalClass //Inconsistent accessability. 
    ///Derived class can't have more accessability than base class
    //{
    //}

    //public class NewClass
    //{
    //    public InternalClass Method() The return values of a method must have greater accessibility
    //than that of the method itself.

    //    {
    //        InternalClass tier = new InternalClass();
    //        return tier;
    //    }
    //}

     sealed class HelicopterSealed
      { }
    //class New:HelicopterSealed Cannot derive from sealed class
    //{ }

    class Program
    {
        static void Main(string[] args)
        {
            MotorcyclePublic.CalculatepricePublic(); // can access method BBB as it's public and method CONTMILEAGE 
                                                     //(although it's private by default) as it's class member and UPDATEOWNER (it's protected) as it's class member
                                                     // Motorcycle.Countmileage() --- can't access method as it's private by default
                                                     //Motorcycle.Updateowner() --- can't access this class as it's protected
            MotorcyclePublic.CalculatepricePublic();

            MotorcyclePublic.Boat.AddBoat();// member of the class can access private and protected methods
            MotorcyclePublic.Bicycle.AddInfo(); // we can access all methods as class Bicycle is class 'Motorcycle' member
            //Electrocar.UpdateOwner(); --- derived class can't access protected class in Main method
            Electrocar.CalculatepricePublic();

            BicycleInternal bianche = new BicycleInternal();
            //bianche.Getpeed(); //can't access internal class even the method is public

            BicyclePublic speedo = new BicyclePublic();
            //speedo.GetSpeed(); //can't access private method of public class

            BicyclePublicInternalMethod aist = new BicyclePublicInternalMethod();
            aist.Getspeed();
        }
    }
}


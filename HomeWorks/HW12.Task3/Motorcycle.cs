using System;
using System.Collections.Generic;
using System.Text;

namespace HW12.Task3
{
    public class Motorcycle
    {
        private int id;
        private string model;
        private string productionyear;
        private string horsepower;
        private string milage;

        public int ID { get; set; }
        public string Model { get; set; }
        public string Productionyear { get; set; }

        //public string Productionyear { get => Productionyear = productionyear; set => Productionyear = value; }
        //public string Horsepower { get => Horsepower = horsepower; set => Horsepower = value; }
        //public string Milage { get => Milage = milage; set => Milage = value; }

        public Motorcycle()
        {   ID = id;
            Model = model;
            //Productionyear =productionyear;
            //Horsepower = horsepower;
            //Milage = milage;
        }
    }
}

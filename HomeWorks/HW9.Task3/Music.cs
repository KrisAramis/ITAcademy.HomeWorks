using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace HW9.Task3
{
    class Music : CatalogItem
    {
        protected string Singer;
        protected double Length;

        public string _Singer
        {
            get => Singer;
            set => Singer = value;
        }

        public double _Length
        {
            get => Length;
            set => Length = value;
        }

        public void Play()
        {

        }

        public void RetrieveInformation()
        {

        }
    }
}

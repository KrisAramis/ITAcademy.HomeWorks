using System;
using System.Collections.Generic;
using System.Text;

namespace HW9.Task3
{
     class Films:CatalogItem
    {
        protected string MainActor;
        protected string MainActress;
        protected string Director;

          Films()
        {

        }

        Films(string MainActor, string MainActress, string Director)
        {

        }
        public string _MainActor
        {
            get => MainActor;
            set => MainActor = value;
        }

        public string _MainActress
        {
            get => MainActress;
            set => MainActress = value;
        }

        public string _Director
        {
            get => Director;
            set => Director = value;
        }
    }
}

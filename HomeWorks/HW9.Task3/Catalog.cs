using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HW9.Task3
{
    class CatalogItem
    {
        protected string Name;
        protected double Code;
        protected string Category;
        protected double Size;

        public CatalogItem()
        {

        }
        public CatalogItem(string Name, double Code, string Category, double Size)
        {
            this.Name = Name;
            this.Code = Code;
            this.Category = Category;
            this.Size = Size;
        }
        public string _Name
        {
            get => Name;
            set => Name = value;
        }

        public double _Code
        {
            get => Code;
            set => Code = value;
        }

        public string _Category
        {
            get => Category;
            set => Category = value;
        }

        public double _Size
        {
            get => Size;
            set => Size = value;
        }
    }
}

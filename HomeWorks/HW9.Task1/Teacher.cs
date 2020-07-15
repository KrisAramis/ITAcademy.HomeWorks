using System;
using System.Collections.Generic;
using System.Text;

namespace HW9.Task1
{
    class Teacher:Person
    {
        private string subject { get; set; }
        public void Explain()
        {
            Console.WriteLine("Explanation  begin");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HW12.Task1
{
    class Person
    {
        private int id;
        private string name;
        private string lastname;
        private int passportId;
        private bool baggagetocheckin;
        private  bool ischeckedin;
        private bool validvisa;
        
        public int Id
        { private get; set; }

        public bool Ischeckedin
        {  get => ischeckedin;
            set=> ischeckedin = value; }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Lastname
        {
            get => lastname;
            set => lastname = value;
        }
        public int PassportId
        {
            get => passportId;
            set => passportId = value;
        }
        public bool Baggagetocheckin
        {
            get => baggagetocheckin;
            set => baggagetocheckin = value;
        }

        public Person()
        {
            name = Name;
            lastname = Lastname;
            baggagetocheckin = Baggagetocheckin;
        }
    }
}

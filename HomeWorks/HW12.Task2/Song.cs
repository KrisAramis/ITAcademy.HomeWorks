using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HW12.Task2
{
    class Song
    {
        private string name;
        private string duration;
        private string author;
        private string productionyear;
        private Genres genre;

        public string Name
        { get => name; set => name = value; }
        public string Duration
        { get=> duration; set=> duration =value; }
        public string Author
        { get => author; set => author = value; }
        public string Productionyear
        { get => productionyear; set => productionyear = value; }
        public Genres Genres
        { get; set; }

        Person p2 = new Person("Bill", "Gates");
        p2.Display();
            class Employee:Person
        {
            public override Display()
            { Consoq.Writeline()}
        }
        class Manager : Employee
        {
            public Manager(string name, string lastname, string company)
                : base(name, lastname, company)
            { }
            public override sealed Display()
            {
                base.Display()
                Console.WriteLine("This is manager");
            }


        }

            public virtual void Display()
        {
            Console.WriteLine(Firstname + "" + Lastname);
        }
        public Song()
        {
            Name = name;
            Duration = duration;
            Author = author;
            Productionyear = productionyear;
            Genres = genre ;
        }
        public void  GetSongData( Song song)
        {
            var melody = new { song.Duration, song.Author, song.Productionyear };
            Console.WriteLine($"Duration: {melody.Duration}, Author: {melody.Author}, Productionyear: { melody.Productionyear}");
        }
    }
}

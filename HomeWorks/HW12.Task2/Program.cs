using System;

namespace HW12.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Song lala = new Song() { Name = "LAL", Duration = "3:39", Author = "Osho",Productionyear =  "2003", Genres = Genres.classic };
            lala.GetSongData(lala);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HW12.Task1
{
    class PassportControl:Answer
        //проверяем пасспорт 
    {
        public string answer;
        public static void CheckBoardingPass(string answer)

        {
            switch (answer)
            {
                case "yes":
                    Console.WriteLine("Give your passport please");
                    break;
                case "no":
                    Console.WriteLine("Have a nice flight!");
                    break;
            }
        }
    }
}

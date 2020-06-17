using System;

namespace HW04.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a 'W', 'A', 'S' or 'D'");
            string symbol = Console.ReadLine();
            switch (symbol)
            {
                case "W":
                    turn_up moveup = new turn_up();
                    moveup.turnup();
                    Console.WriteLine("moveup");
                    break;
                case "S":
                    turn_down movedown = new turn_down();
                    movedown.turndown();
                    Console.WriteLine("movedown");
                    break;
                case "A":
                    turn_right moveright = new turn_right();
                    moveright.turnright();
                    Console.WriteLine("moveright");
                    break;
                case "D":
                    turn_left moveleft = new turn_left();
                    moveleft.turnleft();
                    Console.WriteLine("moveleft");
                    break;
                default:
                    Console.WriteLine("No move required");
                    break;
            }

        }
    }
}

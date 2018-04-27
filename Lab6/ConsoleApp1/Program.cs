using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static Random rndi = new Random();
        static int Count = 0;
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)

            {
                Console.WriteLine("Do you feel lucky? Let's get ready to Roll!!!");

        
                int sides = UserInput("How many sides do you want your dice to have?...");
                int dice1 = RandomDiceRoll(1, sides);
                int dice2 = RandomDiceRoll(1, sides);
                Count++;
                Console.WriteLine("Roll " + Count);
                Console.WriteLine("1st Die :" + dice1);
                Console.WriteLine("2nd Die :" + dice2);
                Console.WriteLine(Craps(dice1, dice2));
                repeat = Continue("Would you like to try your luck again?");

            }
            
        }
        public static int UserInput(string Message)
        {
            Console.WriteLine(Message);
            if (int.TryParse((Console.ReadLine()), out int Value))
            {
                return Value;
            }
            else
            {
                return UserInput("Invalid input. " + Message);
            }
        }
        public static int RandomDiceRoll(int min, int max)
        {
            int winnum = rndi.Next(1, max + 1);
            return winnum;
        }

        public static string Craps(int dice1, int dice2)
        {
            int x = dice1;
            int y = dice2;

            if (x == 1 & y == 1)
                return "Snake Eyes!!";
            else if (x + y == 7 || x + y == 11)
                return "Craps!!";
            else if (x == y)
                return "Pairs";
            else
                return "Field";




        }

        public static bool Continue(string Message)
        {
            while (true)
            {
                Console.WriteLine(Message);
                string input = Console.ReadLine().ToUpper();
                if (input == "N")
                    {
                    return false;
                    }
                else if (input == "Y")
                    {
                    return true;
                    }
                else
                    {
                    Console.WriteLine("Invalid input, try again");
                    }
            }
            

        }
    }
}

using System;

namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int winNum = r.Next(0,100);
            bool win = false;

            do
            {
                Console.WriteLine("Guess a number between 0 and 100: ");
                string s = Console.ReadLine();
                int i = int.Parse(s);

                if(i > winNum)
                {
                    Console.Write("Too high!");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Too low!");
                }
                else if (i == winNum)
                {
                    Console.WriteLine();
                    Console.WriteLine("You win!");
                    win = true;
                }
                Console.WriteLine();
            }
            while (win == false);
            Console.WriteLine("Thank you for playing!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}

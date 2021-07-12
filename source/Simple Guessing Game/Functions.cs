using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Guessing_Game
{
    public class Functions
    {
        
        public Functions()
        {
            
        }
        public static void MainMenu()
        {
            //try catch for error handling
            int selecteditem = 0;
            Console.WriteLine();
            Console.WriteLine("- Welcome to the Main Menu -");
            Console.WriteLine("- Please select a Menu Item -");
            Console.WriteLine();
            Console.WriteLine("1 - Guessing Game");
            Console.WriteLine("2 - View Current Secrets");
            Console.WriteLine("3 - Add A New Secret");
            Console.WriteLine("4 - Change the Number of Available Guesses");
            Console.WriteLine();
            selecteditem = Convert.ToInt32(Console.ReadLine());
            while(selecteditem != 1 & selecteditem != 2 & selecteditem != 3 & selecteditem != 4)
            {
                Console.WriteLine("Invalid menu item number. Please enter a valid menu item number.");
                selecteditem = Convert.ToInt32(Console.ReadLine());
            }
            if(selecteditem == 1)
            {
                Functions.Guessgame();
            }
            if(selecteditem ==2)
            {
                Console.WriteLine("UNDER CONSTRUCTION");
            }
            if(selecteditem ==3)
            {
                Console.WriteLine("UNDER CONSTRUCTION");
            }
            if(selecteditem ==4)
            {
                Console.WriteLine("UNDER CONSTRUCTION");
            }
        }
        public static void Guessgame()
        {
            List <string> secrets;
            string filepath = "secret.txt";
            secrets = File.ReadAllLines(filepath).ToList();
            string guess = "";
            int guesscount = 0;
            int guesslimit = 3;
            bool outofguesses = false;
            
            Console.WriteLine("- Guessing Game -");
            Console.WriteLine();
            Console.WriteLine("Which secret word would you like to guess: ");
            string selectedsecret = Console.ReadLine();
            string secretWord = secrets[Convert.ToInt32(selectedsecret)];
            while(guess != secretWord && !outofguesses)
            {
                if(guesscount < guesslimit)
                {
                Console.WriteLine($"You have {guesslimit-guesscount} guesses remaining.");
                Console.WriteLine("Enter guess: ");
                guess = Console.ReadLine();
                guesscount++;
                Console.WriteLine();
                }
                else
                {
                    outofguesses = true;
                }
            }
            if (outofguesses)
            {
            Console.WriteLine("You Lose!");  
            }
            else
            {
            Console.WriteLine("You Win!");  
            }
            Console.ReadLine();
        }
    }
}

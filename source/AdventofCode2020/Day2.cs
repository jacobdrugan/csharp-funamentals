using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.IO;
using System.Timers;
using System.Diagnostics;

namespace AdventofCode2020
{
    public class Day2
    {
        public static void maintask()
        {
            //Get Input
            string filepath = "day2.txt";
            string[] puzzleinput = File.ReadAllLines(filepath).ToArray();
            // string frequency = "";
            string requirement = "";
            string password = "";
            char letter;
            int min = 0;
            int max = 0;
            int validcount = 0;
            int invalidcount = 0;
            
            //1-5 k: kkkkhkkkkkkkkkk

            foreach (string pass in puzzleinput)
            {
                int matchedchars = 0; 
                string[] puzzleinputsplit = pass.Split(':');
                var req = puzzleinputsplit[0].Trim();
                password = puzzleinputsplit[1].Trim();
                //Console.WriteLine(password);
                string[] puzzleinputsplitrequirements = req.Split(' ');
                requirement = puzzleinputsplitrequirements[0].Trim();
                letter = Convert.ToChar(puzzleinputsplitrequirements[1].Trim());
                //Console.WriteLine(letter);
                string[] minmax = requirement.Split('-');
                min = Convert.ToInt32(minmax[0]);
                max = Convert.ToInt32(minmax[1]);
                //Console.WriteLine(min);
                //Console.WriteLine(max);
                //Go through each character in the password
                char[] charlist = new char[password.Length];
                charlist = password.ToCharArray();
                
                // for(int i = 0; i < password.Length; i++)
                // {
                //     //Console.WriteLine(charlist[i]);
                //     if (charlist[i] == letter)
                //     {
                //         matchedchars++;
                //     }
                // }
                foreach (char letters in charlist)
                {
                    if (letters == letter)
                    {
                        matchedchars++;
                    }
                }
                //Validate Characters
                if (matchedchars <= max && matchedchars >= min)
                {
                    validcount++;
                }
                else
                {
                    invalidcount++;
                }
            }
            Console.WriteLine($"Valid Passwords: {validcount}");
            Console.WriteLine($"Invalid Passwords: {invalidcount}");
        }
    }
}

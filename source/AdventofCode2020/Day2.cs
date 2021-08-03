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
        public static void part1()
        {
            string filepath = "inputs/day2.txt";
            string[] puzzleinput = File.ReadAllLines(filepath).ToArray();
            string requirement = "";
            string password = "";
            char letter;
            int min = 0;
            int max = 0;
            int validcount = 0;
            int invalidcount = 0;

            foreach (string pass in puzzleinput)
            {
                int matchedchars = 0; 
                string[] puzzleinputsplit = pass.Split(':');
                var req = puzzleinputsplit[0].Trim();
                password = puzzleinputsplit[1].Trim();
                string[] puzzleinputsplitrequirements = req.Split(' ');
                requirement = puzzleinputsplitrequirements[0].Trim();
                letter = Convert.ToChar(puzzleinputsplitrequirements[1].Trim());
                string[] minmax = requirement.Split('-');
                min = Convert.ToInt32(minmax[0]);
                max = Convert.ToInt32(minmax[1]);
                char[] charlist = new char[password.Length];
                charlist = password.ToCharArray();

                foreach (char letters in charlist)
                {
                    if (letters == letter)
                    {
                        matchedchars++;
                    }
                }
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
        public static void part2()
        {
            string filepath = "inputs/day2.txt";
            string[] puzzleinput = File.ReadAllLines(filepath).ToArray();
            string requirement = "";
            string password = "";
            char letter;
            int min = 0;
            int max = 0;
            int validcount = 0;
            int invalidcount = 0;
            var counter = 0;

            foreach (string pass in puzzleinput)
            {
                string[] puzzleinputsplit = pass.Split(':');
                var req = puzzleinputsplit[0].Trim();
                password = puzzleinputsplit[1].Trim();
                string[] puzzleinputsplitrequirements = req.Split(' ');
                requirement = puzzleinputsplitrequirements[0].Trim();
                letter = Convert.ToChar(puzzleinputsplitrequirements[1].Trim());
                string[] minmax = requirement.Split('-');
                min = Convert.ToInt32(minmax[0]);
                max = Convert.ToInt32(minmax[1]);
                char[] charlist = new char[password.Length];
                charlist = password.ToCharArray();
                
                //4-5 l: lll d v
                
                counter++;
                Console.WriteLine($"Current Password {counter}");
                Console.WriteLine($"Password Letter: {letter}");
                Console.WriteLine($"Lower Value: {min} {charlist[min-1]}");
                Console.WriteLine($"Upper Value: {max} {charlist[max-1]}");
                //1-4 x: m xk x cndbsfvfnxjwxh
                if (charlist[min-1] == letter || charlist[max-1] == letter)
                {
                    Console.WriteLine("MATCH");
                    validcount++;
                }
                else
                {
                    Console.WriteLine("FALSE");
                    invalidcount++;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Valid Passwords: {validcount}");
            Console.WriteLine($"Invalid Passwords: {invalidcount}");
        }
    }
}

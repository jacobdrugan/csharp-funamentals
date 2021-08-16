using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.IO;
using System.Timers;
using System.Diagnostics;

namespace AdventofCode2020
{
    public class Day3
    {
        public static void part1()
        {
            string filepath = "inputs/day3.txt";
            string [] puzzleinput = File.ReadAllLines(filepath).ToArray();
            int horizontalmove = 0;
            int veritcalmove = 0;
            int currentpos = 0;

            // gets index of this character in the first row
            // Console.WriteLine(puzzleinput[0]);
            // Console.WriteLine(puzzleinput[0].IndexOf('#'));
            // Console.WriteLine(puzzleinput[0][0]);
            //Loop through each line
            //Apply Horizontal Movement
            //Apply Vertical Movement
            foreach (var line in puzzleinput)
            {
                Console.WriteLine(line);
                //apply horizontal move
                //check for tree
                //apply vertical
                //check for tree
                //repeat
                foreach (char letter in line)
                {
                    //Console.WriteLine(letter);
                    // while ()
                    // {
                    // }
                    if (currentpos > 10)
                    {
                        currentpos - 10;
                    }
                }
                
            }

        }
    }
}
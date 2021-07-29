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
            string frequency = "";
            string requirement = "";
            string password = "";
            string letter = "";
            int min = 0;
            int max = 0;
            
            //1-5 k: kkkkhkkkkkkkkkk

            foreach (string pass in puzzleinput)
            {
                string[] puzzleinputsplit = pass.Split(':');
                // pass = pass.Split(':');
                var req = puzzleinputsplit[0].Trim();
                password = puzzleinputsplit[1].Trim();
                //Console.WriteLine(password);
                string[] puzzleinputsplitrequirements = req.Split(' ');
                requirement = puzzleinputsplitrequirements[0].Trim();
                letter = puzzleinputsplitrequirements[1].Trim();
                //Console.WriteLine(letter);
                string[] minmax = requirement.Split('-');
                min = Convert.ToInt32(minmax[0]);
                max = Convert.ToInt32(minmax[1]);
                //Console.WriteLine(min);
                //Console.WriteLine(max);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Timers;
using System.Diagnostics;

namespace AdventofCode2020
{
    public class Day1
    {
        public static void part1()
        {
            string filepath = "inputs/day1.txt";
            List<int> puzinp = File.ReadAllLines(filepath).Select(Int32.Parse).ToList();
            List<int> puzinplow;
            puzinplow = new List<int>();
            List<int> puzinphigh;
            puzinphigh = new List<int>();
            int med = puzinp.Count()/2;
            int val0 = 0;
            int val1 = 0;
            int val2 = 0;
            int target = 2020;

            //NEED TO CUT NUMBERS WITH NO CHANCE
            //CLEAN OUT IMPOSSIBLE COMBINATIONS
            //MEDIAN METHOD NOT VERY EFFECTIVE
            //grab last number named x, find the target y = 2020 - x, and the simple solution is to do a foreach (a in porizinp) if (a==y) {success; break}
            //var index = prizinput.length/2
            //while (index > 0 && index < prizinput.length)
            //{
            //if (prizinp[index] == y)
            //{
            ////success    
            //break;
            //}
            //else if (pizinp[index] < y)
            //{
            //index = index/2; 
            //}
            //else 
            //{
            //index = index + (index/2)    
            //}
            //}
            
            puzinp.Sort();
            foreach(int a in puzinp)
            {
                if (a > puzinp[med])
                {
                    puzinphigh.Add(a);
                }
                else
                {
                    puzinplow.Add(a);
                }
            }
            foreach(int highlistitem in puzinphigh)
            {
                val0 = target-highlistitem;
                
                foreach(int lowlistitem in puzinplow)
                {
                    if(val0 == lowlistitem)
                    {
                        val2 = lowlistitem;
                        val1 = highlistitem;
                    }
                }
            }
            // Console.WriteLine($"{val1}+{val2}={val1+val2}");
            // Console.WriteLine($"High value = {val1}");
            // Console.WriteLine($"Low value = {val2}");      
            Console.WriteLine($"Final Result = {val1*val2}"); 
        }
        public class part2
        {
            public static void maintask()
            {
                string filepath = "inputs/day1.txt";
                List<int> input = File.ReadAllLines(filepath).Select(Int32.Parse).ToList(); 
            }
        }
    }
}

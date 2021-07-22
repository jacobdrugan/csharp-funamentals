using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Timers;
using System.Diagnostics;

namespace AdventofCode2020
{
    public class Day1Part1
    {
        public static void maintask()
        {
            string filepath = "day1.txt";
            List<int> puzinp = File.ReadAllLines(filepath).Select(Int32.Parse).ToList();
            List<int> puzinplow;
            puzinplow = new List<int>();
            List<int> puzinphigh;
            puzinphigh = new List<int>();
            int med = puzinp.Count()/2;
            int b = 0;
            int val0 = 0;
            int val1 = 0;
            int val2 = 0;
            int target = 2020;
            
            puzinp.Sort();
            foreach(int a in puzinp)
            {
                if (puzinp[b] > puzinp[med])
                {
                    puzinphigh.Add(a);
                    b++;
                }
                else
                {
                    puzinplow.Add(a);
                    b++;
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
    }
}

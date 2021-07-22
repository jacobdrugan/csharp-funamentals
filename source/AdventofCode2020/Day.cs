using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AdventofCode2020
{
    public class Day1
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
            int d = 0;
            int val0 = 0; 
            int val1 = 0;
            int val2 = 0;
            int target = 2020;

            //Order list
            puzinp.Sort();

            //Split at median
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
            foreach(int listitem in puzinphigh)
            {
                val0 = target-listitem;
                if(val0 = puzinplow[d])
                {
                    
                }
                else
                {

                }
            }
            // foreach(int c in puzinphigh)
            // {
            //     Console.WriteLine("HERE");
            //     val0 = (2020 - c);
            //     if(val0 == puzinplow[d])
            //     {
            //         val2 = puzinplow[d];
            //         val1 = puzinphigh[c];
            //     }
            //     else
            //     {
            //         d++;
            //     }
            // }
            // Console.WriteLine($"High value = {val1}");
            // Console.WriteLine($"Low value = {val2}");
            // foreach (int c in puzinphigh)
            // {
            //     Console.WriteLine($"HighList:{c}");       
            // }
            // foreach (int c in puzinplow)
            // {
            //     Console.WriteLine($"LowList:{c}");
            // }
            //take top away from 2020 and see if small matches result 2020 - x smaller than x  
            
        }
    }
}

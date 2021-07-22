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
            //var target = 2020;
            //Order list
            puzinp.Sort();
            foreach (int a in puzinp)
            {
                Console.WriteLine($"{a}");
            }
            //Find Median
            int med = puzinp.Count()/2;
            //Split at median
            foreach(int a in puzinp)
            {
                if(puzinp[a] > med)
                    {
                    Console.WriteLine(a);
                    }
                else
                    {
                    Console.WriteLine("BELOW");
                    }
            }
            //take top away from 2020 and see if small matches result 2020 - x smaller than x  
            
        }
    }
}

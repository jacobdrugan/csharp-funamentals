using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Timers;
using System.Diagnostics;

namespace AdventofCode2020
{
    public class Day1Part2
    {
        public static void maintask()
        {
            string filepath = "day1.txt";
            List<int> input = File.ReadAllLines(filepath).Select(Int32.Parse).ToList(); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Timers;
using System.Diagnostics;

namespace AdventofCode2020
{
    public class TestFile
    {
        public static void maintask()
        {
            string filepath = "day1.txt";
            List<int> input = File.ReadAllLines(filepath).Select(Int32.Parse).ToList(); 
            var y = 2020;

            //CLEAN OUT IMPOSSIBLE COMBINATIONS
            //MEDIAN METHOD NOT VERY EFFECTIVE
            //grab last number named x, find the target y = 2020 - x, and the simple solution is to do a foreach (a in porizinp) if (a==y) {success; break}
            foreach (var ind in input)
            {
                var index = input.Count/2;
                while(index > 0 && index < input.Count)
                {
                    if (input[index] == y)
                    {
                        Console.WriteLine("SUCCESS!");
                        Console.WriteLine(index);
                        break;
                    }
                    else if (input[index] < y)
                    {
                        index = index/2;
                        Console.WriteLine(index);
                    }
                    else
                    {
                        index = index + (index/2) ;
                        Console.WriteLine(index);
                    }
                }
            }
        }
    }
}

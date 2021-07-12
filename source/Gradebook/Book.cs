using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Book
    {
        public List <int> grades;
        public string name;
        public Book(string name)
        {
            grades = new List<int>();
            this.name = name;
        }
        public void AddGrade(int grade)
        {
            grades.Add(grade);
        }
        public void GenerateRandomGrades()
        {
            Random rand = new Random();
            while(grades.Count < 5)
            {
                int randomnumber = rand.Next(1,100);
                AddGrade(randomnumber);
                //Console.WriteLine($"{randomnumber}");
            }
        }
        internal void ShowStatistics()
        {
            var highgrade = double.MinValue;
            var lowgrade = double.MaxValue;
            var avggrade = 0d;
            foreach(var number in grades)
            {
                if(number > highgrade) {
                    highgrade = number;
                }
                if(number < lowgrade){
                    lowgrade = number;
                };
                avggrade += number;
            }
            avggrade /= grades.Count;
            Console.WriteLine("");
            Console.WriteLine($"Highest Grade: {highgrade}");
            Console.WriteLine($"Lowest Grade: {lowgrade}");
            Console.WriteLine($"Average Grade: {avggrade}");
            Console.WriteLine("");
        }
        internal void ListItems()
        {
            foreach (int grade in grades) {
                int pos = grades.IndexOf(grade);
                Console.WriteLine($"List item #{pos+1}: {grade}");
            }
        }
    }
}
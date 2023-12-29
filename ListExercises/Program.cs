using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");
            List<int> nums = new List<int> { 5, 12, 16, 7, 0, 38, 1, 3, 72, 53 };
            //List<string> words = new List<string> { "converse", "alter", "book", "memory", "conit" };
           
            string sentence = "I would not, could not, in a box. I would not, could not with a fox." +
                " I will not eat them in a house. I will not eat them with a mouse.";
            string[] arrSpace = sentence.Split(" ");
            List<string> words =  sentence.Split(" ").ToList();
            sumOfEvenNum(nums);
            wordLength(words);
        }

        public static void sumOfEvenNum(List<int> nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                if (num % 2 == 0)
                    sum += num;
            }
            Console.WriteLine("Sum of Even number: " + sum);
        }

        public static void wordLength(List<string> names)
        {
            Console.Write("Enter the the word length of the search: ");
            string input = Console.ReadLine();
            int len = int.Parse(input);
            foreach (string name in names)
            {
                if (name.Length == len)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}

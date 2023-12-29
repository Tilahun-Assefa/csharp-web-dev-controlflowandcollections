using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "I would not, could not, in a box. I would not, could not with a fox." +
                " I will not eat them in a house. I will not eat them with a mouse.";
            string[] arrSpace = sentence.Split(" ");

            Console.WriteLine(string.Join(",", arrSpace));
        }
    }
}

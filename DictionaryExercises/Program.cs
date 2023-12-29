using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string input;
            Console.WriteLine("Enter student ID(or Enter to finish): ");
            //get student id and name
            do
            {
                Console.Write("Student ID: ");
                input = Console.ReadLine();

                if (!input.Equals(""))
                {
                    int studentID = int.Parse(input);
                    Console.Write("Student Name: ");
                    input = Console.ReadLine();
                    string name = input;
                    students.Add(studentID, name);
                }
            } while (!input.Equals(""));

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine("ID: "+ student.Key + " Name: " + student.Value );
            }
        }
    }
}

﻿using System;
namespace DisplayHello
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
            Console.WriteLine("Enter a name's student");
            string input = Console.ReadLine();
            bool isExist = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Equals(input))
                {
                    Console.WriteLine("Position of the student in the list " + input + " is: " + (i + 1));
                    isExist = true;
                    break;
                }

            }
            if (!isExist)
            {
                Console.WriteLine("Not found " + input + " in the list");
            }

        }
    }
}


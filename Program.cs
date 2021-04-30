using System.Diagnostics;
using System;
using System.Linq;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            initiateApp();

        }

        public static void initiateApp()
        {
            Console.WriteLine("Welcome to your CGPA Calculator App");

            Console.WriteLine("How many subjects score would you like to calculate?");
            string subjects = Console.ReadLine();
            int validsubject;
            while (!int.TryParse(subjects, out validsubject))
            {
                Console.WriteLine("Please enter a valid number of subject score to continue");
                subjects = Console.ReadLine();

            }
            Calculate(validsubject);

        }

        public static void Calculate(int no_of_subjects_score)
        {
            double[] scores = new double[no_of_subjects_score];


            for (int i = 0; i < no_of_subjects_score; i++)
            {

                Console.WriteLine($"Please enter your scores over 100 for subject {i + 1}");
                string score = Console.ReadLine();

                while (!double.TryParse(score, out scores[i]))
                {
                    Console.WriteLine("This is not a Valid number\n");
                    Console.WriteLine("Please enter a Valid number");
                    score = Console.ReadLine();

                }

                scores[i] = double.Parse(score);


            }

            double totalscores = scores.Average();

            foreach (var eachscore in scores)
            {
                Console.WriteLine($"The score you entered is {eachscore}");
            }


            Console.WriteLine($"Your CGPA is { Math.Round(totalscores * 0.1, 2)}");
            Console.WriteLine($"Your Percentage is {Math.Round(totalscores * 0.1 * 9.5, 2)}%");

            PromptUser();

        }

        public static void PromptUser()
        {
            Console.WriteLine("\n Do you want to perform another calculation?, Enter yes or no");
            string response = Console.ReadLine().ToLower();

            if (response == "yes")
            {
                initiateApp();

            }

            if (response == "no")
            {
                Console.WriteLine("Thanks, You dont want to perform another calculation");
            }

        }

    }


}


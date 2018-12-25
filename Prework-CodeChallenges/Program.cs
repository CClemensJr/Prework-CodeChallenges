using System;
using System.Collections.Generic;

namespace Prework_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the Code 401 .Net Prework Code Challenges.");
            Console.WriteLine("Which challenge would you like to attempt first? Please enter the number of the preferred challenge:");
            Console.WriteLine("1. Array Max Result");
            Console.WriteLine("2. Leap Year Calculator");
            Console.WriteLine("3. Perfect Sequence");

            int challengeNumber = int.Parse(Console.ReadLine());

            switch (challengeNumber)
            {
                case 1:
                    checkNumberScore();
                    break;
                case 2:
                    checkLeapYear();
                    break;
                case 3:
                    checkPerfectSequence();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number.");
                    break;
            }

            Console.ReadLine();
        }

        /**********************
         * ********** Problem 1
         * ********************/
        static void checkNumberScore()
        {
            Console.WriteLine("Welcome to your first challenge!");
            Console.WriteLine("Please provide me five numbers between 1 and 10:");

            int[] userNumbers = new int[5];

            for (int i = 0; i < 5; i++)
            {

                userNumbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Thank you for your input. Here is the array of numbers you've selected: [{string.Join(", ", userNumbers)}]");

            Console.WriteLine("Now, what is your favorite number out of the ones provided: ");
            int userFavoriteNumber = int.Parse(Console.ReadLine());

            int userNumberScore = getArrayMaxResult(userNumbers, userFavoriteNumber);

            Console.WriteLine($"Your number score is: {userNumberScore}");
        }

        static int getArrayMaxResult(int[] numArray, int usrNum)
        {
           int timesInArray = 0;

           foreach(var num in numArray)
           {
                if (num == usrNum) timesInArray++;
           }

           return usrNum * timesInArray;
        }



        /**********************
         * ********** Problem 2
         * ********************/
         static void checkLeapYear()
         {
            Console.WriteLine("Welcome to the second challenge!");
            Console.WriteLine("Please give me a year. I will let you know if it was a leap year!");

            int userYear = int.Parse(Console.ReadLine());

            bool isLeapYear = leapYearCalculator(userYear);

            if (isLeapYear)
            {
                Console.WriteLine($"{userYear} is a leap year!");
            }
            else
            {
                Console.WriteLine($"{userYear} is not a leap year.");
            }
         }

        static bool leapYearCalculator(int year)
        {
            if ((year % 400 == 0 && year % 100 == 0) || (year % 4 == 0 && year % 100 != 0)) return true;

            return false;
        }



        /**********************
         * ********** Problem 3
         * ********************/
        static void checkPerfectSequence()
        {
            Console.WriteLine("Welcome to the third challenge!");
            Console.WriteLine("If you will give me a sequence of integers, I will tell you if they make up a perfect sequence! Enter 'DONE' when you have finished.");

            int i = 0;
            string userInput;
            var userSequence = new List<int> {};

            do
            {
                userInput = Console.ReadLine();

                if (userInput != "DONE") userSequence.Add(int.Parse(userInput));

                i++;
            } while (userInput != "DONE");

            Console.WriteLine($"Here is the sequence you gave me: [{string.Join(", ", userSequence)}]");

            bool isPerfectSequence = analyzeSequence(List<int> userSequence);

            if (isPerfectSequence)
            {
                Console.WriteLine("Your sequence is a perfect sequence!");
            }
            else
            {
                Console.WriteLine("Unfortunately your sequence was not a perfect one");
            }

        }
    }
}

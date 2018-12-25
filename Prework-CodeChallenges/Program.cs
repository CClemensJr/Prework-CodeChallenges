using System;

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

            int challengeNumber = int.Parse(Console.ReadLine());

            if (challengeNumber == 1)
            {
                checkNumberScore();
            }
            else
            {
                checkLeapYear();
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
    }
}

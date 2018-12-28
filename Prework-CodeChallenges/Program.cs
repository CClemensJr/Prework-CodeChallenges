using System;
using System.Collections.Generic;

namespace Prework_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the Code 401 .Net Prework Code Challenges.");
            Console.WriteLine("Which challenge would you like to attempt first?");
            Console.WriteLine("[1]. Array Max Result");
            Console.WriteLine("[2]. Leap Year Calculator");
            Console.WriteLine("[3]. Perfect Sequence");
            Console.WriteLine("[4]. Sum of Rows");
            Console.WriteLine();

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
                case 4:
                    checkSumOfRows();
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
            Console.WriteLine();
            Console.WriteLine("Welcome to ARRAY MAX RESULT!");
            Console.WriteLine("Please provide me five numbers between 1 and 10:");
            Console.WriteLine();

            int[] userNumbers = new int[5];

            for (int i = 0; i < 5; i++)
            {

                userNumbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine($"Thank you for your input. Here is the array of numbers you've selected: [{string.Join(", ", userNumbers)}]");
            Console.WriteLine();
            Console.Write("Now, which of these numbers do you favor? ");
     
            int userFavoriteNumber = int.Parse(Console.ReadLine());

            int userNumberScore = getArrayMaxResult(userNumbers, userFavoriteNumber);

            Console.WriteLine();
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
            Console.WriteLine();
            Console.WriteLine("Welcome to LEAP YEAR CALCULATOR!");
            Console.Write("Provide a year and I will confirm the year's leap year status:  ");

            int userYear = int.Parse(Console.ReadLine());

            bool isLeapYear = leapYearCalculator(userYear);

            if (isLeapYear)
            {
                Console.WriteLine();
                Console.WriteLine($"{userYear} is a leap year!");
            }
            else
            {
                Console.WriteLine();
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
            Console.WriteLine();
            Console.WriteLine("Welcome to PERFECT SEQUENCE!");
            Console.WriteLine("Provide some numbers and I will tell you if they make up a perfect sequence! Enter 'DONE' when finished.");
            Console.WriteLine();

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

            bool isPerfectSequence = analyzeSequence(userSequence);

            if (isPerfectSequence)
            {
                Console.WriteLine();
                Console.WriteLine("Congratulations! You have a perfect sequence on your hands.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("I must extend the most humble of apologies. What you presented, though beautiful and a sequence, was not a perfect sequence.");
            }

        }

        static bool analyzeSequence(List<int> sequence)
        {
            int sequenceSum = 0;
            int sequenceProduct = 1;

            foreach (int num in sequence)
            {
                if (num < 0) return false;

                sequenceSum += num;
                sequenceProduct *= num;
            }

            if (sequenceSum == sequenceProduct)
                return true;
            else
                return false;
        }



        /**********************
         * ********** Problem 4
         * ********************/
        static void checkSumOfRows()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to challenge number four!");
            Console.WriteLine("So this challenge is going to require a bit more participation on your part.");
            Console.WriteLine("I am going to provide you with the sum for each row in a multi-demensional array but it is up to you to determine how many rows and columns there are.");
            Console.WriteLine();
            Console.Write("Rows: ");

            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Columns: ");

            int columns = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"ROWS = {rows} AND COLUMNS = {columns}");
            Console.WriteLine("Now did you want to [p]rovide the numbers for each rows yourself or let me [r]andomly assign numbers for you?");

            Console.WriteLine();
            string mode = Console.ReadLine();

            if (mode == "p")
            {
                chooseNumbers(rows, columns);
            }
            else if (mode == "r")
            {
                randomlyAssignNumbers(rows, columns);
            }
            else
            {
                Console.WriteLine("Please enter p to provide the numbers yourself or r to have them randomly assigned");
            }
        }

        static void chooseNumbers(int rows, int columns)
        {
            int[,] grid = new int[rows, columns];
            Console.WriteLine($"Please provide {columns} numbers for each row:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Row {i + 1}, number {j + 1}: ");
                    grid[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Thank you. Now here is what your array looks like: ");

            for (int i = 0; i < rows; i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{string.Join(", ", grid[i, j])} ");
                }

                Console.WriteLine("}");
            }

            int[] rowSums = addRows(grid);

            Console.WriteLine($"Here are the sums for each row of the custom array: [{string.Join(", ", rowSums)}]");

        }

        static void randomlyAssignNumbers(int rows, int columns)
        {
            Random randomNumber = new Random();
            int[,] grid = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    grid[i, j] = randomNumber.Next(-1000, 1000);
                }
            }

            for (int i = 0; i < rows; i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{string.Join(", ", grid[i, j])} ");
                }

                Console.WriteLine("]");
            }

            int[] rowSums = addRows(grid);

            Console.WriteLine($"Here are the sums for each row of the random array: [{string.Join(", ", rowSums)}]");
        }

        static int[] addRows(int[,] grid)
        {
            int[] sums = new int[grid.GetLength(0)];

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                int rowSum = 0;

                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    rowSum += grid[i, j];
                }

                sums[i] = rowSum;
            }

            return sums;
        }
    }
}

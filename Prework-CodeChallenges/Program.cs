using System;

namespace Prework_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            getNumberScore();

            Console.ReadLine();
        }

        
        static void getNumberScore()
        {
            Console.WriteLine("Hello and welcome to your first challenge!");
            Console.WriteLine("Please provide me five numbers between 1 and 10:");

            int[] userNumbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                userNumbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Thank you for your input. Here is the array of numbers you've selected: [{string.Join(", ", userNumbers)}]");

            Console.WriteLine("Now, please tell me your favorite number out of the ones provided: ");
            int userFavoriteNumber = int.Parse(Console.ReadLine());

            int userNumberScore = getArrayMaxResult(userNumbers, userFavoriteNumber);

            Console.WriteLine($"Your number score is: {userNumberScore}");
        }


        static int getArrayMaxResult(int[] numArray, int selection)
        {
           int timesInArray = 0;

            int userNum = selection;

           foreach(var num in numArray)
           {
                if (num == userNum) timesInArray++;
           }

           return userNum * timesInArray;
        }
    }
}

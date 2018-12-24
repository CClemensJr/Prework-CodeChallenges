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
            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                string num = Console.ReadLine();

                arr[i] = int.Parse(num);
            }

            Console.WriteLine($"Thank you for your input. Here is the array of numbers you've selected: [{string.Join(", ", arr)}]");

            Console.WriteLine("Now, please tell me your favorite number out of the ones provided: ");
            string favNum = Console.ReadLine();

            int numberScore = getArrayMaxResult(arr, favNum);

            Console.WriteLine($"Your number score is: {numberScore}");
        }


        static int getArrayMaxResult(int[] numArray, string selection)
        {
           int timesInArray = 0;

           int userNum = int.Parse(selection);

           foreach(var num in numArray)
           {
                if (num == userNum) timesInArray++;
           }

           return(userNum * timesInArray);
        }
    }
}

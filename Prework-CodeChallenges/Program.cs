using System;

namespace Prework_CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 6, 4, 4, 1, 3 };
            int chosen = 4;
            getArrayMaxResult(arr, chosen);
            Console.ReadLine();
        }

        
        static void getArrayMaxResult(int[] numArray, int selection)
        {
            int timesInArray = 0;

           foreach(var num in numArray)
           {
                if (num == selection) timesInArray++;
           }

           Console.WriteLine(selection * timesInArray);
        }
    }
}

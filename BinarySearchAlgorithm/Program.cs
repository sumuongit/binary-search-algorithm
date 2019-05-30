using System;

namespace BinarySearchAlgorithm
{
    public class BinarySearch
    {
        int[] numberArray = new int[] { 1, 5, 17, 20, 23, 30, 38, 40, 46, 50, 59, 60, 67, 70, 74 };
        bool isAvailable = false;

        public bool DoSearch(int inputKeyNumber)
        {
            int minimumNumber = 0;
            int maximumNumber = numberArray.Length - 1;
            
            while (minimumNumber <= maximumNumber)
            {
                int midNumber = (maximumNumber + minimumNumber) / 2;
                if (inputKeyNumber == numberArray[midNumber])
                {
                    isAvailable = true;
                    return isAvailable;
                }
                else if (inputKeyNumber > numberArray[midNumber])
                {
                    // Goes to the right half of the range
                    minimumNumber = midNumber + 1;
                }
                else if (inputKeyNumber < numberArray[midNumber])
                {
                    // Goes to the left half of the range
                    maximumNumber = midNumber - 1;
                }                         
            }

            return isAvailable;
        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INPUT: An array of sorted numbers is as follows:");
            Console.WriteLine("================================================");
            Console.WriteLine("1, 5, 17, 20, 23, 30, 38, 40, 46, 50, 59, 60, 67, 70, 74");
            Console.WriteLine();
            Console.Write("Please enter a search key number: ");            
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            BinarySearch bs = new BinarySearch();
            bool keyNumberInArray = bs.DoSearch(input);
            if (keyNumberInArray)
            {
                Console.WriteLine("OUTPUT: The given number is available in the array");
            }
            else
            {
                Console.WriteLine("OUTPUT: The given number is NOT available in the array");
            }

            Console.ReadLine();
        }
    }
}

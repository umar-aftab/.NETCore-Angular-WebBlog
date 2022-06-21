using System;

namespace ConsoleApp_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Manually sort the numbers in the following array in the order of highest to lowest using simple C# only (ie: without using the System.Collection.Sort(), Array.Sort(), LINQ, or any other built-in or imported sorting methods):

            int[] numbers = { 15, 29, 2, 5, 92, 44, 12, 102, 86 };

            //Please print the sorted numbers at the end of the program.

            for(int i = 0; i < numbers.Length - 1; i++)
            {
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        int temp=numbers[j];
                        numbers[j]=numbers[i];
                        numbers[i]=temp;

                    }
                }
            }
            
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}

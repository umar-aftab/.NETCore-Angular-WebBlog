using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a= IsPrime(5);
            Console.WriteLine(a);
            Console.ReadLine();
        }

        public static bool IsPrime(int number)
        {
            if(number < 2)
            {
                return false;
            }
            if (number%2 != 0)
            {
                return true;
            }
            return false;
        }
    }
}

using System;

namespace Homework4
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Please, enter the integer number that bigger than 20 or equal:");

            string userString = Console.ReadLine();

            int n;

            while (!int.TryParse(userString, out n) || n < 20)
            {
                Console.WriteLine("ERROR, your number isn't valid");
                Console.Write("Please, enter the integer number that bigger than 20 or equal:");

                userString = Console.ReadLine();
            }

            var arrayWithRandomNumbers = GenerateIntArray(1, 27, n);

            int countOfOddNumbers = CountOfOddNumbersInArray(arrayWithRandomNumbers);

            var upperSymbols = new char[] { 'A', 'E', 'I', 'D', 'H', 'J' };

            var oddArr = new string[countOfOddNumbers];
            var evenArr = new string[n - countOfOddNumbers];

            int counterOfOdd = 0;
            int counterOfEven = 0;

            foreach (int elem in arrayWithRandomNumbers)
            {
                char symbol = Convert.ToChar(elem + 64);

                if (Array.IndexOf(upperSymbols, symbol) == -1)
                {
                    symbol = char.ToLower(symbol);
                }

                if (elem % 2 == 1)
                {
                    oddArr[counterOfOdd] = symbol.ToString();

                    counterOfOdd++;
                }
                else
                {
                    evenArr[counterOfEven] = symbol.ToString();

                    counterOfEven++;
                }
            }

            Console.Write("First array:");

            foreach (string elem in oddArr)
            {
                Console.Write(" " + elem);
            }

            Console.WriteLine(string.Empty);
            Console.Write("Second array:");

            foreach (string elem in evenArr)
            {
                Console.Write(" " + elem);
            }
        }

        private static int CountOfOddNumbersInArray(int[] arrayWithRandomNumbers)
        {
            int countOfOddNumbers = 0;

            foreach (int elem in arrayWithRandomNumbers)
            {
                if (elem % 2 == 1)
                {
                    countOfOddNumbers++;
                }
            }

            return countOfOddNumbers;
        }

        private static int[] GenerateIntArray(int minValue, int maxValue, int arrayLength)
        {
            var randomizer = new Random();

            var arrayWithRandomNumbers = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                arrayWithRandomNumbers[i] = randomizer.Next(minValue, maxValue);
            }

            int countOfOddNumbers = CountOfOddNumbersInArray(arrayWithRandomNumbers);

            return arrayWithRandomNumbers;
        }
    }
}

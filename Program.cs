using System;

namespace ShiftArrayValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int tempNumber;
            int lastNumber;

            int lastIndex = numbers.Length - 1;

            Console.WriteLine("Исходная матрица:");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Введите значение сдвига влево:");
            int shift = Convert.ToInt32(Console.ReadLine());

            if (shift == numbers.Length)
            {
                shift = 0;
            }
            else if (shift > numbers.Length)
            {
                int difference = shift % numbers.Length;
            }

            for (int i = 0; i < shift; i++)
            {
                lastNumber = numbers[lastIndex];
                numbers[lastIndex] = numbers[0];

                for (int j = 0; j < lastIndex - 1; j++)
                {
                    tempNumber = numbers[j];
                    numbers[j] = numbers[j + 1];
                }

                numbers[lastIndex - 1] = lastNumber;
            }

            Console.WriteLine("Матрица со сдвигом:");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}

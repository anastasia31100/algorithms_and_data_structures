using System;

namespace семенар
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = SumOfDigitsOfNumbers(1, 100);
            Console.WriteLine(res);
        }
        // метод, который возвращает сумму четных чисел от 1 до 100
        static int SumOfDigitsOfNumbers(int left,  int right)
        {
            int sum = 0;
            for(int number = left; number <= right; number ++)
            {
                int tmp = Math.Abs(number);
                while(tmp > 0)
                {
                    if (tmp % 2 == 0)
                        sum += tmp % 10;
                    tmp /= 10;
                }
            }
            return sum;
        }
    }

}
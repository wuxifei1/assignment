using System;
using System.Collections.Generic;

namespace HW2.GetPrimeFactors
{
    class Program
    {
        static void Main()
        {
            Console.Write("请输入一个整数：");
            int number = int.Parse(Console.ReadLine());
            List<int> primeFactors = GetPrimeFactors(number);
            Console.WriteLine($"素数因子：{string.Join(", ", primeFactors)}");
        }


        static List<int> GetPrimeFactors(int number)
        {
            List<int> factors = new List<int>();
            for (int i = 2; i <= number; i++)
            {
                while (number % i == 0 && IsPrime(i))
                {
                    if (!factors.Contains(i))
                        factors.Add(i);
                    number /= i;
                }
            }
            return factors;
        }

        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
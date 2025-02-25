using System;

namespace HW2.OpOfArray
{
    class ArrayOperations
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 }; // 示例数组
            int max = numbers.Max();
            int min = numbers.Min();
            int sum = numbers.Sum();
            double average = numbers.Average();
            Console.WriteLine($"最大值：{max}, 最小值：{min}, 和：{sum}, 平均值：{average}");
        }
    }
}

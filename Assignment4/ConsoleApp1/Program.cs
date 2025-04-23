using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        delegate void Func(List<int> list);
        static void Main(string[] args)
        {
            List<int> numList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Action<int> action = delegate (int num)
            {
                Console.Write(num + " ");
            };
            numList.ForEach(action);
            Console.WriteLine();
            Func getMax = numList =>
            {
                int max = numList[0];
                foreach (int num in numList)
                {
                    if (num > max)
                    {
                        max = num;
                    }
                }
                Console.WriteLine("最大值为：" + max);
            };
            Func getMin = numList =>
            {
                int min = numList[0];
                foreach (int num in numList)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }
                Console.WriteLine("最小值为：" + min);
            };
            Func getAvg = numList =>
            {
                int result, sum = 0;
                foreach (int num in numList)
                {
                    sum += num;
                }
                result = sum / numList.Count;
                Console.WriteLine("平均值为：" + result);
            };
            getMax(numList);
            getMin(numList);
            getAvg(numList);
            
        }
    }
}

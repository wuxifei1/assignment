// 使用System命名空间
using System;
// 第一次作业
namespace HW1.CaculatorConsole
{
    class Caculator
    {
        public static void Main(string[] args)
        {
            try
            {
                int num1, num2;
                char op;
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                op = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (op)
                {
                    case '+':
                        Console.WriteLine($"num1 + num2 = {num1 + num2}");
                        break;
                    case '-':
                        Console.WriteLine($"num1 - num2 = {num1 - num2}");
                        break;
                    case '*':
                        Console.WriteLine($"num1 * num2 = {num1 * num2}");
                        break;
                    case '/':
                        Console.WriteLine($"num1 / num2 = {num1 / num2}");
                        break;
                }
            }
            catch (Exception ex) when (ex is ArgumentNullException || ex is OutOfMemoryException)
            {
                // 同时处理 ArgumentNullException 和 InvalidOperationException
                Console.WriteLine("捕获到指定异常: " + ex.Message);
            }
            catch (Exception ex)
            {
                // 处理其它所有异常
                Console.WriteLine("捕获到其它异常: " + ex.Message);
            }
        }
    }
}
using System;

namespace Fig_3._14
{
    class 檔案總管右方重新命名
    {
        static void Main(string[] args)
        {
            int Number1;
            int Number2;
            int Sum;

            Console.Write("Enter the first number: ");
            Number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            Number2 = int.Parse(Console.ReadLine());

            Sum = Number1 + Number2;

            Console.WriteLine($"Sum is {Sum}");
        }
    }
}

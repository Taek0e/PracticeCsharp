using System;

namespace CSpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하시오.");
            string inputNum = Console.ReadLine();
            int num = int.Parse(inputNum);

            Console.WriteLine($"당신이 입력한 수는 {num}입니다.");
        }
    }
}

using System;
using System.Linq;

namespace ArithmeticProgressionMember
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var numbers = input.Split(' ').Select(int.Parse).ToArray();
            var a = numbers[0];
            var d = numbers[1];
            var n = numbers[2];
            Console.Write(a + (n - 1) * d);
        }
    }
}

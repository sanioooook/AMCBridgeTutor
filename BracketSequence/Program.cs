using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BracketSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var numbers = input.Split(' ').Select(int.Parse).Skip(1).ToArray();
            /*var counterBracket = numbers[0];*/
            /*numbers = numbers.ToArray();*/
            Console.Write("{0}", IsBalanced(numbers) ? 1 : 0);
        }
        private static bool IsBalanced(IEnumerable<int> brackets)
        {
            var stack = new Stack<int>();
            var openingBrackets = new[] {-1, -2, -3};
            foreach(var bracket in brackets)
            {
                if(Array.Exists(openingBrackets, i => bracket == i))
                {
                    stack.Push(bracket);
                }
                else
                {
                    if(stack.Count == 0)
                    {
                        return false;
                    }
                    var top = stack.Pop();
                    if((top == 3 && bracket != -3) || (top == 2 && bracket != -2) || (top == 1 && bracket != -1))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}

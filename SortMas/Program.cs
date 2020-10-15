using System;
using System.Linq;

namespace SortMas
{
    class Program
    {
        private static readonly Func<int[], int[]> QSortArray =
            arr => arr.Length.Equals(0)
                ? new int[] { }
                : (QSortArray(Array.FindAll(arr, num => num.CompareTo(arr[0]) < 0))
                    .Concat(Array.FindAll(arr, num => num.CompareTo(arr[0]) == 0))
                    .Concat(QSortArray(Array.FindAll(arr, num => num.CompareTo(arr[0]) > 0)))).ToArray();

        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var numbers = input.Split(' ').Select(int.Parse).ToList();
            var lengthMas = numbers[0];
            numbers.RemoveAt(0);
            Console.Write("{0}", lengthMas);
            foreach(var i in QSortArray(numbers.ToArray()))
            {
                Console.Write(" {0}", i);
            }
        }
    }
}

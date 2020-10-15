using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DoesPointBelongTo3DSegment
{

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var numbers = input.Split(' ').Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToArray();
            var listPoint = new List<Point>();
            for(var i = 0; i < numbers.Length; i += 3)
            {
                listPoint.Add(new Point() { X = numbers[i], Y = numbers[i + 1], Z = numbers[i + 2] });
            }

            if(listPoint[0].X <= listPoint[2].X && // X2 <= X <= X1 AND
               listPoint[0].X >= listPoint[1].X && // Y2 <= Y <= Y1 AND
               listPoint[0].Y <= listPoint[2].Y && // Z2 <= Z <= Z1
               listPoint[0].Y >= listPoint[1].Y &&
               listPoint[0].Z <= listPoint[2].Z &&
               listPoint[0].Z >= listPoint[1].Z)
            {
                Console.Write(1);
            }
            else
            {
                Console.Write(0);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace CarWash
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var numbers = input.Split(' ').ToArray();

            var totalConst = new List<int>();
            foreach(var carWash in numbers)
            {
                if(carWash != "-1")
                {
                    var total = 0;
                    switch(carWash[0])
                    {
                        case '1':
                        {
                            total += carWash[1] == '1' ? 20 : 0;
                            total += carWash[2] == '1' ? 10 : 0;
                            total += carWash[3] == '1' ? 15 : 0;
                            break;
                        }
                        case '2':
                        {
                            total += carWash[1] == '1' ? 7 : 0;
                            total += carWash[2] == '1' ? 2 : 0;
                            total += carWash[3] == '1' ? 5 : 0;
                            break;
                        }
                        case '3':
                        {
                            total += carWash[1] == '1' ? 5 : 0;
                            break;
                        }
                    }
                    totalConst.Add(total);
                }
            }
            Console.Write(totalConst.Sum());
            foreach(var i in totalConst)
            {
                Console.Write(" " + i);
            }
            Console.Write(" -1");
        }
    }
}

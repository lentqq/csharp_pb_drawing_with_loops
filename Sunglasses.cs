﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Top row

            Console.WriteLine("{0} {1} {0}", new string('*', 2 * n), new string(' ', n));

            //Midlle rows

            for (int i = 0; i < n - 2; i++)
            {
               
                if (i == (n - 1) / 2 - 1)
                {
                    Console.Write("*{0}*{1}*{0}*", new string('/', (2 * n) - 2), new string('|', n + 2));
                }
                else
                {
                    Console.Write("*{0}*{1}*{0}*", new string('/', (2 * n) - 2), new string(' ', n + 2));

                }
                Console.WriteLine();
            }

            //Down row

            Console.WriteLine("{0} {1} {0}", new string('*', 2 * n), new string(' ', n));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                // Console.WriteLine("{0}{1} | {1}{0}", new string(' ', n - i), new string('*', i));
                Console.WriteLine($"{new string(' ', n - i)} {new string('*', i)} | {new string('*', i)} {new string(' ', n - i)} ");
            }
        }
    }
}

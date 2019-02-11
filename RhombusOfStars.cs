using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                Console.Write(new string(' ', n - row));
                Console.Write("*");

                for (int j = 0; j < row; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n-1 ; i++)
            {
                Console.Write(new string(' ', 2 + i));
                Console.Write("*");

                for (int j = 0; j < n - 2 -i ; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}

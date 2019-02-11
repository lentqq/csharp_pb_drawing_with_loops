using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1 || n == 2)
                Console.WriteLine(new string('*', n));
            else
            {
                int startStars = 2 - n % 2;
                int topRows = (n + 1) / 2;
                int lowRows = n - topRows;

                ////Top row
                int startDashes = (n - startStars) / 2;
                Console.Write(new string('-', startDashes));
                Console.Write(new string('*', startStars));
                Console.WriteLine(new string('-', startDashes));

                // Top midlle rows
                for (int i = 0; i < topRows - 1; i++)
                {
                    int insideDashes = startStars + i * 2;
                    int outSideDashes = (n - 2 - insideDashes) / 2;
                    Console.Write(new string('-', outSideDashes));
                    Console.Write('*');
                    Console.Write(new string('-', insideDashes));
                    Console.Write('*');
                    Console.WriteLine(new string('-', outSideDashes));
                }

                //Low midlle rows
                if (n % 2 == 0)
                {
                    for (int i = 1; i < lowRows - 1; i++)
                    {
                        int insideDashes = n - 2 * i - 2;
                        int outSideDashes = (n - 2 - insideDashes) / 2;
                        Console.Write(new string('-', outSideDashes));
                        Console.Write('*');
                        Console.Write(new string('-', insideDashes));
                        Console.Write('*');
                        Console.WriteLine(new string('-', outSideDashes));
                    }
                }
                else
                {
                    for (int i = 1; i < lowRows; i++)
                    {
                        int insideDashes = n - 2 * i - 2;
                        int outSideDashes = (n - 2 - insideDashes) / 2;
                        Console.Write(new string('-', outSideDashes));
                        Console.Write('*');
                        Console.Write(new string('-', insideDashes));
                        Console.Write('*');
                        Console.WriteLine(new string('-', outSideDashes));
                    }
                }
                //Low row

                Console.Write(new string('-', startDashes));
                Console.Write(new string('*', startStars));
                Console.WriteLine(new string('-', startDashes));
            }
        }
    }
}



 
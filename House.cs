using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Roof

            int topRoofStars = 2 - n % 2;
            int roofRows = (n + 1) / 2;
            int baseRows = n - roofRows;
            int topDashes = (n - topRoofStars) / 2;

            Console.Write(new string('-', topDashes));
            Console.Write(new string('*', topRoofStars));
            Console.WriteLine(new string('-', topDashes));

            for (int i = 1; i <= roofRows - 1; i++)
            {
                int otherStars = topRoofStars + i * 2;
                int otherDashes = (n - otherStars) / 2;
                Console.Write(new string('-', otherDashes));
                Console.Write(new string('*', otherStars));
                Console.WriteLine(new string('-', otherDashes));
            }
            //Base
            for (int i = 0; i < baseRows; i++)
            {
                Console.Write('|');
                Console.Write(new string('*', n - 2));
                Console.WriteLine('|');
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Fibonachi();

        }
        public static void Fibonachi()
        {

            Console.WriteLine("До какого числа считать Фибоначчи? ");
            int n = Int32.Parse(Console.ReadLine());

            int x = 1;

            int y = 1;

            int s = 0;

            while (s < n)
            {

                s = y + x;
                Console.WriteLine(s);

                x = y;
                y = s;

            }
            Console.ReadLine();
        }
    }
}

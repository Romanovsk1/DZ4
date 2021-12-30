using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DZ4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine();
            var words = str.Split();
            int sum = 0;
            
            for (int i = 0; i < words.Length; sum += int.Parse(words[i++])) ;
            Console.WriteLine(sum);

            
            Console.ReadLine();
        }   
    }
}
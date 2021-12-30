using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4._3
{
    internal class Program
    {
        
        private enum YearSeason
        {
            Winter, 
            Spring,  
            Summer,  
            Autumn 
        }


        static void Main(string[] args)
        {

            Season();
            
        }


        public static void Season()
        {
           
            string winter = "Зима";
            string spring = "Весна";
            string summer = "Лето";
            string autumn = "Осень";


            Console.WriteLine("Введите номер текущего месяца ");
            byte monthNumber = Convert.ToByte(Console.ReadLine());

            

            if (monthNumber < 1 || monthNumber > 12)
            {
                Console.WriteLine("Неверный ввод, номер должен быть от 1 до 12");
                return;
            }


            byte s = (byte)monthNumber;


            if ((s == 1) || (s == 2) || (s == 12))
            {
                Console.WriteLine($"{YearSeason.Winter} {winter}");
            }

            else if ((s == 3) || (s == 4) || (s == 5))
            {
                Console.WriteLine($"{YearSeason.Spring} {spring}");
            }

            else if ((s == 6) || (s == 7) || (s == 8))
            {
                Console.WriteLine($"{YearSeason.Summer} {summer}");
            }

            else if ((s == 9) || (s == 10) || (s == 11))
            {
                Console.WriteLine($"{YearSeason.Autumn} {autumn}");
            }
            
           
            Console.ReadLine();
        
        }

    }
}

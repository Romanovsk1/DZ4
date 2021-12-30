using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string firstName, string lastName, string patronimic)[] array = 
            {
                ("Романов","Владимир","Владимирович"),
                ("Сталин","Николай","Иосевович"),
                ("Левов","Лев","Львовович"),
                ("Цульм","Александра","Александровна")
            };

            for (var i = 0; i < array.Length; i++)
                Console.WriteLine(GetFullName(array[i].firstName, array[i].lastName, array[i].patronimic));

            
            Console.ReadLine();
        }

        static string GetFullName(string firstName, string lastName, string patronymic) =>
            $"{firstName} {lastName} {patronymic}";
    }
}







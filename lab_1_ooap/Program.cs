using System;

using System.Collections;
using System.Collections.Generic;

namespace lab_1_ooap
{
    class Program
    {
        static void Main(string[] args)

        {
            Listbook homeLibrary = new Listbook();
            homeLibrary.Add(new Listbook { Number = 1, Author = "Ессенин", Year = 1900, Category = "Стихи" });
            homeLibrary.Add(new Listbook { Number = 2, Author = "Пушкин", Year = 1910, Category = "Рассказы" });
            homeLibrary.Add(new Listbook { Number = 3, Author = "Лермонтов", Year = 1920, Category = "Басни" });
            homeLibrary.Add(new Listbook { Number = 4, Author = "Достоевский", Year = 1910, Category = "Стихи" });
            homeLibrary.ShowScreen();
            homeLibrary.Remove(new Listbook { Number = 3, Author = "Лермонтов", Year = 1920, Category = "Басни" });
            homeLibrary.ShowScreen();

            Console.WriteLine("По какому критерию будем производить поиск? (По автору-1, год издания-2, по категории-3," +
                              "по номеру -4)");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Введите  писателя");
                    homeLibrary.Search(Console.ReadLine(), number);
                    break;
                case 2:
                    Console.WriteLine("Введите  год издания");
                    homeLibrary.Search(Console.ReadLine(), number);
                    break;
                case 3:
                    Console.WriteLine("Введите  категорию");
                    homeLibrary.Search(Console.ReadLine(), number);
                    break;
                case 4:
                    Console.WriteLine("Введите  номер книги");
                    homeLibrary.Search(Console.ReadLine(), number);
                    break;
                default:
                    Console.WriteLine("Не правильный критерий");
                    break;
            }

            Console.ReadLine();
        }
    }
}



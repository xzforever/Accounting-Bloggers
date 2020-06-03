using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2artile1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number=0;
            Blog blog1 = new Blog("Золотой Воробей", "муж.", 29, 5000000, 60);
            Blog blog2 = new Blog("Красная Акула","жен.",27,120000, 73);
            Blog blog3 = new Blog("Зеленка","жен.", 15 , 25000 , 34);

            blog1.PrintInfo();
            blog2.PrintInfo();
            blog3.PrintInfo();

            bool success = false;
            int i = 3;
            do
            {
                Console.WriteLine("Добавить нового блогера?(да,нет)");
                string input = Console.ReadLine();
                if (input.Contains("да"))
                {
                    success = true;
                    i = i + 1;
                    AddNewBlogger(number, i);
                }
                else break;
            } while (!success);
            Console.WriteLine("Программа завершена!");
        }
        static void CheckInt(int number)
        {
                bool success= false;
            do
            {
                string input = Console.ReadLine();
                success = int.TryParse(input, out number);
                if(!success)
                {
                    Console.WriteLine("Необходимо ввести число!");
                }
            } while (!success);
        }
            static void AddNewBlogger(int number, int i)
            {
            Blog blog = new Blog();
            for(int n =0; n<1; n++)
            {
                string blog4 = ($"blog{i}");
            }
            
            Console.WriteLine("Добавление нового блогера");
            Console.Write("Имя: ");
            blog.Name = Console.ReadLine();
            bool success = false;
            do
            {
                Console.Write("Пол (true - муж , false - жен)");
                blog.Gender = Console.ReadLine();
                if (blog.Gender.Contains("true") || blog.Gender.Contains("false")) success = true;
                if (blog.Gender == "true") blog.Gender = "муж.";
                else blog.Gender = "жен.";
            } while (!success);
            Console.Write("Возраст: ");
            CheckInt(number);
            number = blog.Age;
            Console.Write("Просмотры: ");
            CheckInt(number);
            number = blog.Views;
            Console.Write("Рейтинг: ");
            CheckInt(number);
            number = blog.Rate;
            Console.Clear();

            Blog blog1 = new Blog("Золотой Воробей", "муж.", 29, 500000, 60);
            Blog blog2 = new Blog("Красная Акула", "жен.", 27, 120000, 73);
            Blog blog3 = new Blog("Зеленка", "жен.", 15, 25000, 34);

            blog1.PrintInfo();
            blog2.PrintInfo();
            blog3.PrintInfo();
            blog.PrintInfo();
        }
    }
}

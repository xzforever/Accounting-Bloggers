using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2artile1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Blog blog1 = new Blog("Золотой Воробей", "муж.", 29, 500000, 60);
            Blog blog2 = new Blog("Красная Акула","жен.",27,120000, 73);
            Blog blog3 = new Blog("Зеленка","жен.", 15 , 25000 , 34);

            blog1.PrintInfo();
            blog2.PrintInfo();
            blog3.PrintInfo();

            Blog blog4 = new Blog();
            Console.WriteLine("Добавление нового блогера");
            Console.Write("Имя: ");
            blog4.Name = Console.ReadLine();
            bool success = false;
            do
            {
                Console.Write("Пол (true - муж , false - жен)");
                blog4.Gender = Console.ReadLine();
                if (blog4.Gender.Contains("true") || blog4.Gender.Contains("false")) success = true;
                if (blog4.Gender == "true") blog4.Gender = "муж.";
                else blog4.Gender = "жен.";
            } while (!success);
            do
            {
                success = false;
                Console.Write("Возраст: ");
                string input1 = Console.ReadLine();
                success = int.TryParse(input1, out  blog4.Age);
            } while (!success);
            do
            {
                success = false;
                Console.Write("Просмотры: ");
                string input2 = Console.ReadLine();
                success = int.TryParse(input2, out blog4.Views);
            } while (!success);
            do
            {
                success = false;
                Console.Write("Рейтинг: ");
                string input3 = Console.ReadLine();
                success = int.TryParse(input3, out blog4.Rate);
            } while (!success);
            Console.Clear();

            blog1.PrintInfo();
            blog2.PrintInfo();
            blog3.PrintInfo();
            blog4.PrintInfo();
        }
    }
}

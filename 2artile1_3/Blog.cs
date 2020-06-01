using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2artile1_3
{
    class Blog
    {
        public string Name;
        public string Gender;
        public int Age;
        public int Views;
        public int Rate;
        public Blog()
        {
            string name = Name;
            string gender = Gender;
            int age = Age;
            int views = Views;
            int rate = Rate;
        }
        public Blog(string name, string gender, int age, int views, int rate)
        {
            Name = name;
            Gender = gender;
            Age = age;
            Rate = rate;
        }

        public void PrintInfo()
        {
            Console.Write(Name);
            Console.Write($" ({Gender}),");
            Console.Write($" {Age} лет.");
            Console.Write($" Просмотры: {Views},");
            Console.Write($" Рейтинг: {Rate}");
            Console.WriteLine();
        }
    }
}

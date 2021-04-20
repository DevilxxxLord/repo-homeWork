using System;
using System.IO;

namespace Level_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            ReadAddFile();
            //2
            AppendFile();
            //3
            WriteNumber();
            //4         
            Employee[] employees = {
                new Employee("Ivanov Ivan Ivanovich", "Engineer", "ivan@jmail.com", "89634452345", 40000, 30),
                new Employee("Ivanov Dmitrii Dmitrievich", "Programmer", "dmitrii@jmail.com", "89688885434", 80000, 41),
                new Employee("Ivanov Alexander Alexandrovich", "Analyst", "alex@jmail.com", "89634452345", 60000, 40),
                new Employee("Ivanova Svetlana Mihailovna", "Developer", "sveta@jmail.com", "89634452345", 100000, 27),
                new Employee("Ivanov Vladimir Vladimirovich", "Seller", "vlad@jmail.com", "89634452345", 200000, 43)
            };
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Age < 40)
                {
                    Console.WriteLine(employees[i].Info());
                }
            }


        }
        static void ReadAddFile()
        {
            //1
            Console.WriteLine("Введите строку, для добавления в файл .txt:");
            string TextUser = Console.ReadLine();
            File.WriteAllText("text.txt", TextUser);
        }
        static void AppendFile()
        {
            //2
            File.AppendAllText("startup.txt", DateTime.Now.ToLongTimeString() + "\n");
        }
        static void WriteNumber()
        {
            //3
            Console.WriteLine("Введите произвольный набор чисел от 0 до 255:");
            string number = Console.ReadLine();
            File.WriteAllText("number.bin", number);
        }
    }

}

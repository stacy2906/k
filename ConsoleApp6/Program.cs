using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Иванов", "Иван", 1000, 1.5);
            Console.WriteLine("Информация о сотруднике:");
            employee.PrintInfo();
            Console.WriteLine($"Доход: {employee.Income()}");

            Console.WriteLine();

            Engineer engineer = new Engineer("Петров", "Петр", 1200, 1.8, 15);
            Console.WriteLine("Информация об инженере:");
            engineer.PrintInfo();
            Console.WriteLine($"Доход: {engineer.Income()}");
            Console.ReadKey();
        }
    }
}

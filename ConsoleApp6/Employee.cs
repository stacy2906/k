using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Employee
    {
        public string lastName;
        public string firstName;
        public double p;
        public double k;

        public Employee(string lastName, string firstName, double p, double k)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.p = p;
            this.k = k;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Фамилия: {lastName}");
            Console.WriteLine($"Имя: {firstName}");
            Console.WriteLine($"Минимальная зарплата: {p}");
            Console.WriteLine($"Повышающий коэффициент: {k}");
        }

        public double Income()
        {
            return k * p;
        }
    }
}

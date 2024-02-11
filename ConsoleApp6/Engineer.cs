using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Engineer:Employee
    {
        public int n;

        public Engineer(string lastName, string firstName, double p, double k, int n) : base(lastName, firstName, p, k)
        {
            this.n = n;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Количество разработанных проектов: {n}");
        }

        public new double Income() // переопределенный метод с учетом количества разработанных проектов
        {
            if (n > 10)
            {
                return (k * p) * (n / 10);
            }
            return k * p;
        }
    }
}

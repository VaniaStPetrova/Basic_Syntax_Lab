using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int EmployeeID = int.Parse(Console.ReadLine());
            decimal MonthlySalary = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}",name);
            Console.WriteLine("Age: {0}",age);
            Console.WriteLine("Employee ID: {0:D8}",EmployeeID);
            Console.WriteLine("Salary: {0:F2}", MonthlySalary);
        }
    }
}

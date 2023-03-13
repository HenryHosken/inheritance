using System;
using inheritance.Entities;
using System.Globalization;
using System.Collections;

namespace inheritance;

internal class Program
{
    static void Main(string[] args)
    {
        List<Employee> list = new List<Employee>();

        Console.Write("Enter number of employees: ");
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"Employee #{i} Data: ");
            Console.WriteLine("outsourced (y/n) ");
            char ch = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (ch == 'y')
            {
                Console.Write("Additional charge: ");
                double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new OutsourcedEmployee(name, hours, valueHour, additionalCharge));
            } 
            else
            {
                list.Add(new Employee(name, hours, valueHour));
            }

            Console.WriteLine();
            Console.WriteLine("Payments:");

            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + $"- " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
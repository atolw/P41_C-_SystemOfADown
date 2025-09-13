using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P41_C__SystemOfADown
{
    internal class Human
    {
        int age;
        string name;

        public Human(string n, int a)
        {
            name = n;
            age = a;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    class Employee : Human
    {
        int salary;
        public Employee(string n, int a, int s) : base(n, a)
        {
            salary = s;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Salary: {salary}");
        }
    }
}

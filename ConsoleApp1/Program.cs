using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractClass
{
    abstract class SalaryPay
    {
        public abstract double Salary();
    }
    class HourRatePay : SalaryPay
    {
        public override double Salary() //Расчет оплаты повременщиков
        {
            return 20.8 * 8 * 10; 

        }
    }
    class FixedPay : SalaryPay
    {
        public override double Salary() //Фиксированная месячная оплата
        {
            return 1500;
        }
    }
    class Person : IComparable //Применение интерфейса IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CompareTo(object o)
        {
            Person p = o as Person;
            if (p != null)
                return this.Name.CompareTo(p.Name);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Ivanov", Age = 34 };
            Person p2 = new Person { Name = "Petrov", Age = 23 };
            Person p3 = new Person { Name = "Smirnov", Age = 21 };

            Person[] people = new Person[] { p1, p2, p3 };
            Array.Sort(people);

            foreach (Person p in people)
            {
                Console.WriteLine("{0} - {1}", p.Name, p.Age);
            }
            Console.ReadKey();
        }
    }
 }
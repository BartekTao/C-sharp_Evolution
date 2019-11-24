#define example1
using System;

namespace ValueReferenceType
{
#if example1
    class Program
    {
        static void Main(string[] args)
        {
            //value type
            int salary = 43210;
            IncreaseSalary(salary);
            Console.WriteLine($"My salary : {salary}");

            //reference type
            var bartek = new Employee()
            {
                Name = "Bartek",
                ID = "18941",
                Salary = 43210
            };
            IncreaseSalary(bartek);

            Console.WriteLine($"My salary : {bartek.Salary}");
        }

        static void IncreaseSalary(int money)
        {
            //money = money + 3000;
            money += 3000;
        }

        static void IncreaseSalary(Employee employee)
        {
            employee.Salary += 3000;
        }
    }

    public class Employee
    {
        public string Name { get; set; }

        public string ID { get; set; }

        public int Salary { get; set; }
    }
#endif


}

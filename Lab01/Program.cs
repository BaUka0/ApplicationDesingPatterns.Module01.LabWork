using System;
namespace Lab01
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public abstract void CalculateSalary();
    }
    public class Worker : Employee
    {
        public int HourlyRate { get; set; }
        public int HoursCount { get; set; }
        public override void CalculateSalary()
        {
            int salary = HourlyRate * HoursCount;
            Console.WriteLine($"Работник: ID:{Id}, Имя:{Name}, Должность:{Job}, Ставка за час:{HourlyRate}, Количество часов:{HoursCount},Заплата:{salary}");
        }
    }
    public class Manager : Employee
    {
        public int FixedSalary { get; set; }
        public int BonusRate { get; set; }
        public override void CalculateSalary()
        {
            int salary = FixedSalary + BonusRate;
            Console.WriteLine($"Менеджер: ID:{Id}, Имя:{Name}, Должность:{Job}, Фиксированная зарплата:{FixedSalary}, Премиальные:{BonusRate}, Заплата:{salary}");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Employee worker1 = new Worker { Id = 001, Name = "Адам", Job = "Столяр", HourlyRate = 1250, HoursCount = 200};
            Employee manager1 = new Manager { Id = 002, Name = "Ева", Job = "Менеджер по продажам", FixedSalary = 250000, BonusRate = 50000 };
            worker1.CalculateSalary();
            manager1.CalculateSalary();
        }
    }
}
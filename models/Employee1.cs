using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Employee1
    {
        private Guid Id;
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        private double BaseSalary;
        public double PensionPercentage { get; set; }
        public double HealthPercentage { get; set; }
        private double CooperativeSavagesPercentage;

        public Employee1(string name, string lastName, string email, double baseSalary, double pensionPercentage, double healthPercentage, double cooperativeSavagesPercentage)
        {
            Id = Guid.NewGuid();
            Name = name;
            LastName = lastName;
            Email = email;
            BaseSalary = baseSalary;
            PensionPercentage = pensionPercentage;
            HealthPercentage = healthPercentage;
            CooperativeSavagesPercentage = cooperativeSavagesPercentage;
        }

        public double CalculateEmployeeSalary()
        {
            double deductions = CalculateDeductions();
            double netSalary = BaseSalary - deductions;
            return netSalary;
        }
        private double CalculateDeductions()
        {
            double pensionDeduction = BaseSalary * (PensionPercentage /100);
            double healthDeduction = BaseSalary * (HealthPercentage /100);
            double cooperativeDeduction = BaseSalary * (CooperativeSavagesPercentage /100);
            return  pensionDeduction + healthDeduction + cooperativeDeduction ;
        }
        private double CalculateSavings()
        {
            return  BaseSalary * (CooperativeSavagesPercentage /100);
        }
        public void ShowInformation()
        {
            Console.WriteLine($"El Id del empleado es --> {Id}\nEl Nombre del empleado es --> {Name}\nEl Apellido del empleado es --> {LastName}\nEl Correo del empleado es --> {Email}\nEl Sueldo base del empleado es --> {BaseSalary}\nEl Porcentaje de pension es --> {PensionPercentage}%\nEl Porcentaje de salud es --> {HealthPercentage}%\nEl porcentaje de ahorro cooperativa es --> {CooperativeSavagesPercentage}% ");
        }
        public void ShowDeductions()
        {
            Console.WriteLine($"El total de deducciones es --> {CalculateDeductions()}");
        }
        public void ShowSavings()
        {
            Console.WriteLine($"El total de ahorros es --> {CalculateSavings()}");
        }
    }
}
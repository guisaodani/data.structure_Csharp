using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_library
{
    public class SalaryEmployee : Employee
    {
        private decimal _salary;

        public decimal Salary { get => _salary; set => _salary = ValidaSalary(value); }

        public override decimal GetValueToPay()
        {
            return Salary * 0.88m;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                   $"Salary.................: {Salary,20:C2}\n\t" +
                   $"Value To Pay...........: {GetValueToPay(),20:C2}";
        }

        private decimal ValidaSalary(decimal value)
        {
            if (value < 1160000)
            {
                throw new ArgumentException("El salario es menor al minimo ");
            }
            return value;
        }
    }
}
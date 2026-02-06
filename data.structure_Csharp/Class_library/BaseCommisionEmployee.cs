using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_library
{
    public class BaseCommisionEmployee : CommisionEmployee
    {
        private decimal _salary;

        public decimal Salary
        {
            get => _salary;
            set => _salary = ValidateSalary(value);
        }

        public override string ToString()
        {
            return $"{Id}\t{FirstName}\t{LastName}\n\t" +
                   $"Hire.........................: {BornDate}\n\t" +
                   $"Porcentaje Comision..........: {CommisionPercentaje,20:C2}\n\t" +
                   $"Salario Base.................: {Salary,20:C2}\n\t" +
                   $"Ventas.......................: {Sales,20:C2}\n\t" +
                   $"Valor a Pagar................: {GetValueToPay(),20:C2}";
        }

        public override decimal GetValueToPay()
        {
            var salary = base.GetValueToPay() + Salary;
            if (salary < 1160000)
            {
                return 1160000;
            }
            return salary;
        }

        private decimal ValidateSalary(decimal value)
        {
            if (value < 600000)
            {
                throw new ArgumentException("El salario base no es valido");
            }
            return value;
        }
    }
}
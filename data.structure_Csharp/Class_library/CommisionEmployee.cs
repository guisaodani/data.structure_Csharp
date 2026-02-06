using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_library
{
    public class CommisionEmployee : Employee
    {
        private float _commisionPercentaje;
        private decimal _sales;

        public float CommisionPercentaje
        {
            get => _commisionPercentaje;
            set => _commisionPercentaje = ValidateCommisionPercentaje(value);
        }

        public decimal Sales
        {
            get => _sales;
            set => _sales = ValidateSales(value);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                   $"Porcentaje Co..........: {CommisionPercentaje,20:C2}\n\t" +
                   $"Ventas.................: {Sales,20:C2}\n\t" +
                   $"Valor a Pagar..........: {GetValueToPay(),20:C2}";
        }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommisionPercentaje * 0.88m;
        }

        private float ValidateCommisionPercentaje(float value)
        {
            if (value < 0 || value > 1)
            {
                throw new ArgumentException("el porcentaje de comision no es valido");
            }
            return value;
        }

        private decimal ValidateSales(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Las ventas no es valido");
            }
            return value;
        }
    }
}
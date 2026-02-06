using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_library
{
    public class HourlyEmployee : Employee
    {
        private float _workingHour;
        private decimal _hourValue;

        public float WorkingHour
        {
            get => _workingHour;
            set => _workingHour = ValidateWorkingHour(value);
        }

        public decimal HourValue
        {
            get => _hourValue;
            set => _hourValue = ValidateHourValue(value);
        }

        public override decimal GetValueToPay()
        {
            return (decimal)WorkingHour * HourValue * 0.88m;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                   $"Horas Trabajadas.......: {WorkingHour,20:C2}\n\t" +
                   $"Valor Hora.............: {HourValue,20:C2}\n\t" +
                   $"Value To Pay...........: {GetValueToPay(),20:C2}";
        }

        private float ValidateWorkingHour(float value)
        {
            if (value < 0 || value > 240)
            {
                throw new ArgumentException("Las horas trabajadas no son validas");
            }
            return value;
        }

        private decimal ValidateHourValue(decimal value)
        {
            if (value < 30000)
            {
                throw new ArgumentException("las valor de las horas no es valido");
            }
            return value;
        }
    }
}
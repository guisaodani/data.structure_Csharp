using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Class_library
{
    public class Invoice : IPay
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public float Quantity { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Id}\t{Description}\n\t" +
                $"Quantity........{Quantity,20:N2}\n\t" +
                $"Price...........{Price,20:N2}\n\t" +
                $"Value To Pay....{GetValueToPay(),20:N2}\n\t";
        }

        public decimal GetValueToPay()
        {
            return Price * (decimal)Quantity;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoComParcelas.Entities
{
    class Installment
    {
        public DateTime dueDate { get; private set; }
        public double amount { get; private set; }

        public Installment(DateTime dueDate, double amount)
        {
            this.dueDate = dueDate;
            this.amount = amount;
        }
    }
}

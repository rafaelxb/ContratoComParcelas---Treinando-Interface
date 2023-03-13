using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoComParcelas.Entities
{
    class Contract
    {
        public int number { get; private set; }
        public DateTime date { get; private set; }
        public double totalValue { get; private set; }
        public List<Installment> installments { get; private set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            this.number = number;
            this.date = date;
            this.totalValue = totalValue;
            this.installments = null;
        }
    }
}

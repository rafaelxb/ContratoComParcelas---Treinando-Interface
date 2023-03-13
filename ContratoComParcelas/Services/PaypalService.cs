using ContratoComParcelas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoComParcelas.Services
{
    class PaypalService : IInstallmentService
    {
        public List<Installment> Installments(DateTime date, double contractValue, int numberInstallments)
        {
            double valuePerInstallment = contractValue / (double)numberInstallments;
            List<Installment> installments = new List<Installment>();
            for(int installmentNumber = 1; installmentNumber <= numberInstallments; installmentNumber++)
            {
                double percent = (1 * installmentNumber);
                double monthTax = valuePerInstallment * ((percent + 100)/100);
                double installmentValue = monthTax * 1.02;

                Installment installment = new Installment(date.AddMonths(installmentNumber), installmentValue);
                installments.Add(installment);
            }
            return installments;
        }
    }
}

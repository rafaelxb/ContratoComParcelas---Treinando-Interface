using ContratoComParcelas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoComParcelas.Services
{
    class PaymentService
    {
        public DateTime date { get; private set; }
        public double contractValue { get; private set; }
        public int numberInstallments { get; private set; }

        private IInstallmentService _installmentService;

        public PaymentService(DateTime date, double contractValue, int numberInstallments, IInstallmentService installmentService)
        {
            this.date = date;
            this.contractValue = contractValue;
            this.numberInstallments = numberInstallments;
            _installmentService = installmentService;
        }

        public List<Installment> generateInstallments()
        {
            List<Installment> installments = _installmentService.Installments(this.date, this.contractValue,this.numberInstallments);
            return installments;
        }
    }
}

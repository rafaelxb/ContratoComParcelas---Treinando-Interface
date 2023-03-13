using ContratoComParcelas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoComParcelas.Services
{
    interface IInstallmentService
    {
        List<Installment> Installments(DateTime date, double contractValue, int numberInstallments);
    }
}

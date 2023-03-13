using ContratoComParcelas.Entities;
using ContratoComParcelas.Services;
using System.Globalization;

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int contractNumber = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.Parse(Console.ReadLine());
Console.Write("Contract value: ");
double contractValue = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.Write("Number of Installments: ");
int installmentNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Installments: ");

Contract contract = new Contract(contractNumber, date, installmentNumber);

PaymentService paymentService = new PaymentService(date,contractValue,installmentNumber, new PaypalService());

List<Installment> installments = paymentService.generateInstallments();

foreach(Installment installment in installments)
{
    Console.WriteLine($"{installment.dueDate} - {installment.amount.ToString("F2",CultureInfo.InvariantCulture)}");
}


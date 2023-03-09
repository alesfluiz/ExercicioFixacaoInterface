using System;
using System.Globalization;
using ExercicioInterface1.Entities;
using ExercicioInterface1.Services;


namespace Exerciciointerface1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);

            ContractService contractService = new ContractService(new PayPalService());
            contractService.ProcessContract(contract, months);

            Console.WriteLine("Installments: ");
            foreach(Installments installments in contract.Installments)
            {
                Console.WriteLine(installments);
            }
            

        }
    }
}
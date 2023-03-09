using System;
using System.Reflection.Metadata.Ecma335;
using ExercicioInterface1.Entities;

namespace ExercicioInterface1.Services
{
    internal class ContractService
    {

        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;

        }
        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = basicQuota + _onlinePaymentService.PaymentFee(basicQuota);
                double fullQuota = updateQuota + _onlinePaymentService.Interest(updateQuota, i);
                contract.AddInstollments(new Installments(date, fullQuota));
            }
        }

    }

}



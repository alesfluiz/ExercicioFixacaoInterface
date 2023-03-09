using System;

namespace ExercicioInterface1.Services
{
    internal interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}

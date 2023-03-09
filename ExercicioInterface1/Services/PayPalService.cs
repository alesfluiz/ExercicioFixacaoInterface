

namespace ExercicioInterface1.Services
{
    internal class PayPalService : IOnlinePaymentService
    {

        private double FeePercentage = 0.02;
        private double MonthlyInterest = 0.01;

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }
    }
}

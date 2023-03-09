

namespace ExercicioInterface1.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installments> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installments>();
        }
        public void AddInstollments(Installments installments)
        {
            Installments.Add(installments);
        }

        

    }
}

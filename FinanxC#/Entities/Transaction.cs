namespace Finanx.Entities
{
    public class Transaction
    {
        public Transaction(double amount, int installment, DateTime date, string category, string description)
        {
            Amount = amount;
            Installment = installment;
            Date = date;
            Category = category;
            Description = description;
        }

        private readonly string _id;
        private double Amount { get; set; } 
        private int Installment {  get; set; }
        private DateTime Date { get; set; }
        private string Category { get; set; }
        private string Description { get; set; }

    }
}

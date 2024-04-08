namespace Finanx.Entities
{
    public class Transaction
    {
        public Transaction(double amount, DateTime date, string category, string description)
        {
            Amount = amount;
            Date = date;
            Category = category;
            Description = description;
        }

        private readonly string _id;
        private double Amount { get; set; } 
        private DateTime Date { get; set; }
        private string Category { get; set; }
        private string Description { get; set; }

    }
}

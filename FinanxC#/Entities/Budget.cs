namespace Finanx.Entities
{
    public class Budget
    {
        private User Id { get;}
        public Budget(User id, double monthlyLimit) 
        {
            Id = id;
            MonthlyLimit = monthlyLimit;
        }
        private double MonthlyLimit {  get; set; }

    }
}

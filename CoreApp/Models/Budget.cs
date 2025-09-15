namespace ExpensesTracker.Models
{
    public class Budget
    {
        public decimal MonthlyLimit { get; set; }

        public Budget(decimal limit)
        {
            MonthlyLimit = limit;
        }

        public void ShowStatus(decimal totalSpent)
        {
            Console.WriteLine($"Budget: ${MonthlyLimit} | Spent: ${totalSpent} | Remaining: ${MonthlyLimit - totalSpent}");
        }
    }
}

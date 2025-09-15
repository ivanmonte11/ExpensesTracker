namespace ExpensesTracker.CLI
{
    public static class InputValidator
    {
        public static decimal GetValidAmount()
        {
            Console.Write("Enter amount: ");
            string input = Console.ReadLine() ?? "0";

            if (!decimal.TryParse(input, out decimal amount) || amount <= 0)
            {
                Console.WriteLine("Invalid amount. Must be a positive number.");
                return -1;
            }

            return amount;
        }

        public static string GetValidCategory()
        {
            Console.Write("Enter category: ");
            string category = Console.ReadLine()?.Trim();

            return string.IsNullOrWhiteSpace(category) ? "Uncategorized" : category;
        }
    }
}

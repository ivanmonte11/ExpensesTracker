using ExpensesTracker.Models;

namespace ExpensesTracker.CLI
{
    public static class Menu
    {
        public static void Show(User user, Budget budget)
        {
            while (true)
            {
                Console.WriteLine("\n=== Expense Tracker ===");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. List Expenses");
                Console.WriteLine("3. Show Budget Status");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");
                string option = Console.ReadLine();

                if (option == "1") AddExpense(user);
                else if (option == "2") user.ListExpenses();
                else if (option == "3") budget.ShowStatus(user.TotalSpent());
                else if (option == "4") break;
                else Console.WriteLine("Invalid option.");
            }
        }

        private static void AddExpense(User user)
        {
            string category = InputValidator.GetValidCategory();
            decimal amount = InputValidator.GetValidAmount();
            if (amount == -1) return;

            Expense expense = new Expense(DateTime.Now, category, amount);
            user.AddExpense(expense);
            ExpenseRepository.Save(user.Expenses);

            Console.WriteLine($"✔ Expense recorded: {category} - ${amount}");
        }

    }
}
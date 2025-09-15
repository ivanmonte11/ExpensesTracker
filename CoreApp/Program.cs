using ExpensesTracker.Models;
using ExpensesTracker.CLI;

namespace ExpensesTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Iván");
            Budget budget = new Budget(200000);

            // Loading expenses from file
            user.Expenses = ExpenseRepository.Load();

            // Delegate flow to the modular menu
            Menu.Show(user, budget);
        }
    }
}

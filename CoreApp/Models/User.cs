using System.Collections.Generic;
using System.Linq;

namespace ExpensesTracker.Models
{
    public class User
    {
        public string Name { get; set; }
        public List<Expense> Expenses { get; set; } = new List<Expense>();

        public User(string name)
        {
            Name = name;
        }

        public void AddExpense(Expense expense)
        {
            Expenses.Add(expense);
        }

        public decimal TotalSpent()
        {
            return Expenses.Sum(e => e.Amount);
        }

        public void ListExpenses()
        {
            foreach (var expense in Expenses)
            {
                expense.Display();
            }
        }
    }
}

using System.Text.Json;

namespace ExpensesTracker.Models
{
    public static class ExpenseRepository
    {
        private const string FilePath = "expenses.json";

        public static void Save(List<Expense> expenses)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(expenses, options);
            File.WriteAllText(FilePath, json);
        }

        public static List<Expense> Load()
        {
            if (!File.Exists(FilePath)) return new List<Expense>();

            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<Expense>>(json) ?? new List<Expense>();
        }
    }
}

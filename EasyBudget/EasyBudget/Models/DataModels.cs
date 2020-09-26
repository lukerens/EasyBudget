using System;
using System.Collections.Generic;
using System.Text;
using EasyBudget.Models;

namespace EasyBudget.Models
{
    public class Expense
    {
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public ExpenseTypes Categorie { get; set; }
    }
}

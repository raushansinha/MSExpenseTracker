using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSExpenseTracker.Models
{
    public class Expense
    {
        public string Id { get; set; }
        public DateTime exp_date { get; set; }
        public decimal exp_amount { get; set; }
        public string exp_category { get; set; }
        public string exp_description { get; set; }
    }
}

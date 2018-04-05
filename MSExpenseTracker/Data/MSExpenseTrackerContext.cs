using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MSExpenseTracker.Models
{
    public class MSExpenseTrackerContext : DbContext
    {
        public MSExpenseTrackerContext (DbContextOptions<MSExpenseTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<MSExpenseTracker.Models.Expense> Expenses { get; set; }
    }
}

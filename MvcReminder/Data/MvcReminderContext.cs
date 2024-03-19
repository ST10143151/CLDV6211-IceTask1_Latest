using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcReminder.Models;

namespace MvcReminder.Data
{
    public class MvcReminderContext : DbContext
    {
        public MvcReminderContext (DbContextOptions<MvcReminderContext> options)
            : base(options)
        {
        }

        public DbSet<MvcReminder.Models.Reminder> Reminder { get; set; } = default!;
    }
}

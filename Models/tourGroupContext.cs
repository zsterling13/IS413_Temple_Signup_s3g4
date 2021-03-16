using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_Temple_Signup_ZS.Models
{
    public class tourGroupContext : DbContext
    {
        public tourGroupContext (DbContextOptions<tourGroupContext> options) : base (options)
        {

        }

        public DbSet<tourGroup> Groups { get; set; }

        public DbSet<timeSlot> timeSlots { get; set; }
    }
}

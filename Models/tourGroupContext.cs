using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//context database to make sure that everything is good as good and nice 
namespace IS413_Temple_Signup_ZS.Models
{
    public class tourGroupContext : DbContext
    {
        public tourGroupContext (DbContextOptions<tourGroupContext> options) : base (options)
        {

        }

        //Creates a table in the database called Groups that is based on the tourGroup model
        public DbSet<tourGroup> Groups { get; set; }

        //Creates a table in the database called timeSlots that is based on the timeSlot model
        public DbSet<timeSlot> timeSlots { get; set; }
    }
}

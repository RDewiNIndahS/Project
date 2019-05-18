using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjectGetPost.Models
{
    public class DbContex : DbContext
    {
        public DbContex(DbContextOptions<DbContex> options)
            : base(options)
        {
        }
        public DbSet<APP_MINIMUM_DE> app_minimum_de { get; set; }
        public DbSet<APP_SPOUSE> app_spouse { get; set; }
    }
}

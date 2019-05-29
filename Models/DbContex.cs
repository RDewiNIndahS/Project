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
        public DbSet<APP_OTHERCOLDETAILS> app_othercoldetails { get; set; }
        public DbSet<RFDETAILCOLLATERAL> rfdetailcollateral { get; set; }
        public DbSet<RFCOLTYPE> rfcoltype { get; set; }
        public DbSet<COLLATERAL> collateral { get; set; }
        public DbSet<APP_COLMESIN> app_colmesin { get; set; }
        public DbSet<APP_COLKENDARAAN> app_colkendaraan { get; set; }
        public DbSet<APP_COLTANAHBANGUNAN> app_tanahbangunan { get; set; }
        public DbSet<APP_COLSURATBERHARGA> app_suratberharga { get; set; }
    }
}

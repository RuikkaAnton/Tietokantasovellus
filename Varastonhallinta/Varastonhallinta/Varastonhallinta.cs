using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Varastonhallinta
{
    public class Varastonhallinta : DbContext
    {
        public DbSet<Tuote>? Tuotteet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = "Data Source=.;Initial Catalog=Varastonhallinta;User Id=sa;" + 
                "Password=WinterSoldier890;MultipleActiveResultSets=true;" + 
                "TrustServerCertificate=true"; 
            optionsBuilder.UseSqlServer(connection);
        }
    }

}

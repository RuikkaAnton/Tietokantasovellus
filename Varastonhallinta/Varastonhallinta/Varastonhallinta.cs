﻿using System;
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
            string connection = "Data Source=.;Initial Catalog=Testikanta;User Id=sa;" + "Password=Salasana1;MultipleActiveResultSets=true;" + "TrustServerCertificate=true"; 
            //optionsBuilder.UseSqlServer(connection);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CMS.Core.Domain;
using Microsoft.Extensions.Configuration;

namespace CMS.Data.EFCore
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Helper.Constrants.TrustedConnection);
        }

        public DbSet<Student> Students { get; set; }
    }
}
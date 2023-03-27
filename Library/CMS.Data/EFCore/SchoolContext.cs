using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CMS.Core.Domain;

namespace CMS.Data.EFCore
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Helper.Constrants.AuthenticationConnection);
        }

        public DbSet<Student> Students { get; set; }
    }
}
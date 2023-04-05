using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CMS.Core.Domain;
using Microsoft.Extensions.Configuration;
using CMS.Data.Helper;
namespace CMS.Data.EFCore
{
    public class KhangDB : DbContext
    {
        public KhangDB()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Constrants.TrustedConnection);
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
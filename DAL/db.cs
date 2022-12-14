using System;
using System.Collections.Generic;
using System.Text;
using be;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class db : IdentityDbContext<UserApp>
    {
        public db() : base()
        {
        }
        public db(DbContextOptions<db> options) : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO Move connection string to a secure location
            optionsBuilder.UseSqlServer("Data Source=5.160.146.61\\MSSQLSERVER2019; Initial Catalog=BabTeb; User ID=babone; Password=@mj3523510%");
            base.OnConfiguring(optionsBuilder);

        }


        public DbSet<question> questions { get; set; }
        public DbSet<answer> answers { get; set; }
        public DbSet<Introduction> introduction { get; set; }
        public DbSet<package> packages { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Order_package> Order_Packages { get; set; }
        public DbSet<test> tests { get; set; }
    }
}

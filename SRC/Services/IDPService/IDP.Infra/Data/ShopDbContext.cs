using IDP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDP.Infra.Data
{
    public class ShopDbContext:DbContext
    {
        private readonly IConfiguration configuration;

        public ShopDbContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(configuration.GetConnectionString("CommandDBConnection"));
        }
        public DbSet<User> Tbl_Users { get; set; }

    }
}

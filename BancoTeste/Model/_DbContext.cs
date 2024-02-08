﻿using Microsoft.EntityFrameworkCore;

namespace BancoTeste.Model
{
    public class _DbContext : DbContext
    {
        //public DbSet<TabelaAqui> TabelaAqui { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            IConfigurationRoot Configuration = new ConfigurationBuilder()
               .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
               .AddJsonFile("appsettings.json")
            .Build();

            var ConnectionString = Configuration.GetConnectionString("MariaDB");
            OptionsBuilder.UseMySql(ConnectionString, ServerVersion.AutoDetect(ConnectionString));
        }
    }
}

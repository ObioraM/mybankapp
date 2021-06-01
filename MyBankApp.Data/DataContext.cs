using Microsoft.EntityFrameworkCore;
using MyBankApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite(@"Data Source = MyBankSqliteDB ");
            optionsBuilder.UseSqlite(@"Filename =./MyBankDB.sqlite");
        }
        public DbSet<Security> Securities { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}

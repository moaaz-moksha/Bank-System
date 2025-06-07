using Bank.Models;
using Microsoft.EntityFrameworkCore;

namespace Bank.Data
{
    public class appdbcontext : DbContext
    {
        public appdbcontext(DbContextOptions options) : base(options)
        {
        }

        protected appdbcontext()
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasIndex(a => a.AccountNumber).IsUnique();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Account> accounts { get; set; }
        public DbSet<BankCard> bankCards { get; set; }
        public DbSet<Branch> branch { get; set; }
        public DbSet<Customer> customer { get; set; }
    }
}

using ApplicationPhoneBook.DataBase;
using DomainPhoneBook.Entities;
using Microsoft.EntityFrameworkCore;

namespace PersistencePhoneBook.Context
{
    public class DatabaseContext : DbContext, IDataBaseContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-QM4GS45;Initial Catalog=NewDbContact;Integrated Security=True;");
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace ContactManagement.DataAccess
{
    public class ContactsDbContext : DbContext
    {
        // configure the db

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MyContacts2024;Integrated Security=true");
        }


        // configure the tables
        public DbSet<Contact> Contacts { get; set; }


    }
}

using Microsoft.EntityFrameworkCore;

namespace MediatR.Demo.Data
{
    public class ContactsContext : DbContext
    {
        public ContactsContext(DbContextOptions<ContactsContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact { Id = 1, FirstName = "Steve", LastName = "Michelotti", WebSite="www" },
                new Contact { Id = 2, FirstName = "Bill", LastName = "Gates", WebSite = "www" },
                new Contact { Id = 3, FirstName = "Satya", LastName = "Nadella", WebSite = "www" });
        }
    }
}
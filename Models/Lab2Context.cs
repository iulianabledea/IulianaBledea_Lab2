using Microsoft.EntityFrameworkCore;

namespace IulianaBledea_Lab2.Models
{
    public class Lab2Context : DbContext
    {
        public Lab2Context(DbContextOptions<Lab2Context> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
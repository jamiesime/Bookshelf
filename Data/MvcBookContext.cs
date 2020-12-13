using Microsoft.EntityFrameworkCore;
using Bookshelf.Models;

namespace Bookshelf.Data
{
    public class MvcBookContext : DbContext
    {
        public MvcBookContext(DbContextOptions<MvcBookContext> options)
        : base(options)
        {

        }

        public DbSet<Book> books;
    }
}
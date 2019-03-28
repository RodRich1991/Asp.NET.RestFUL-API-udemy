using Microsoft.EntityFrameworkCore;

namespace RestWithAsp.NET_core.UDEMY.V1.Models.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}

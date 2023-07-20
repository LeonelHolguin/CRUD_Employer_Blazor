using Microsoft.EntityFrameworkCore;

namespace CRUD_ServerSide.Models
{
    public class MyEmployersContext : DbContext
    {
        public DbSet<Employer> employers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-F7I84IVN\\SQLEXPRESS;Initial Catalog=CrudServerSide;Integrated Security=True;Encrypt=False");
        }
    }
}

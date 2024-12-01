using Microsoft.EntityFrameworkCore;
using WebApplication2.Models.Entites;

namespace WebApplication2.data
{

    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

    }

}



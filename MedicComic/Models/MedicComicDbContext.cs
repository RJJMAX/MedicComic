using Microsoft.EntityFrameworkCore;

namespace MedicComic.Models
{
    public class MedicComicDbContext : DbContext
    {
        public DbSet<Admin>? Admins { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<CreditCard>? CreditCards { get; set;}
    }
}

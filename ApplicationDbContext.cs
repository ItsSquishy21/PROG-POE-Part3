using Microsoft.EntityFrameworkCore;

namespace CMCS.Web.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Claim> Claims { get; set; }
        public DbSet<UploadFile> UploadFiles { get; set; }
    }
}

using Microsoft.AspNet.Identity.EntityFramework;

namespace MVCRockers.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("MVCRockerDB", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<MVCRockers.Models.Concert> Concerts { get; set; }
    }
}
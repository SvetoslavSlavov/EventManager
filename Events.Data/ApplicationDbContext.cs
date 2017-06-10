namespace Events.Data
{
    using System.Data.Entity;

    using Microsoft.AspNet.Identity.EntityFramework;
    using Events.Service;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public IDbSet<Service.Event> Events { get; set; }
        

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}

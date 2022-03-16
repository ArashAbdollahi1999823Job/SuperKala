using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperKala.Domain.UserAgg;

namespace SuperKala.Infrastructure.Contexts.Identity
{
    public class IdentityContext:IdentityDbContext<User>
    {
        public IdentityContext(DbContextOptions<IdentityContext>options):base(options)
        {
            
        }
    }
}

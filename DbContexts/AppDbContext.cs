using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Authentication_Authorization_AddApiEndpoints.DbContexts
{
    public class AppDbContext(DbContextOptions<AppDbContext> options): IdentityDbContext<IdentityUser>(options)
    {
    }
}

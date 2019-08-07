using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Intillegio.Data.Data
{
    public class IntillegioContext : IdentityDbContext
    {
        public IntillegioContext(DbContextOptions<IntillegioContext> options)
            : base(options)
        {
        }
    }
}

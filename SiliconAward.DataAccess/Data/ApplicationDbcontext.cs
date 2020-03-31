using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SiliconAward.DataAccess.Entities;
using SiliconAward.DataAccess.Entities.Identities;

namespace SiliconAward.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<AspNetUsers>
    {
        public ApplicationDbContext(DbContextOptions option) : base(option) { }
        public DbSet<CustomLog> CustomLogs { get; set; }
        public DbSet<Competition> Competitions { get; set; }
    }
}

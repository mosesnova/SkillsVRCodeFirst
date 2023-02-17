using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace SkillsVRCodeFirst.Models
{
    public class RugbyContext : DbContext
    {
        public RugbyContext(DbContextOptions<RugbyContext> options) : base(options)
        {
        }

        public DbSet<Player> Player { get; set; }

        public DbSet<Team> Team { get; set; }
    }
}

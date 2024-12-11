using Microsoft.EntityFrameworkCore;
using Professions.Models;

namespace Professions.Data 
{
    public class ProfessionsContext : DbContext
    {
        public ProfessionsContext(DbContextOptions<ProfessionsContext> options)
            : base(options)
        {
        }

        public DbSet<Genre> Genres { get; set; }
    }
}


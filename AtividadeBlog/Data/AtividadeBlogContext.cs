using Microsoft.EntityFrameworkCore;

namespace AtividadeBlog.Models
{
    public class AtividadeBlogContext : DbContext
    {
        public AtividadeBlogContext (DbContextOptions<AtividadeBlogContext> options)
            : base(options)
        {
        }

        public DbSet<Categoria> Categoria { get; set; }
    }
}

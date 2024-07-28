using Microsoft.EntityFrameworkCore;

namespace ToDo_List.Models.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<ToDo> ToDos { get; set; }
    }
}

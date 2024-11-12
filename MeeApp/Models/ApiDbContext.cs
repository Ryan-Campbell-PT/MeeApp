using Microsoft.EntityFrameworkCore;

namespace StarterFlutterApp.Models;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Users> Users { get; set; }
    
}
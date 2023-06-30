using System.Collections.Immutable;

namespace Model.Configurations; 

public class ShoppingDbContext : DbContext{
    public ShoppingDbContext(DbContextOptions<ShoppingDbContext> options) : base(options) {
        
    }
    protected override void OnModelCreating(ModelBuilder builder) {
        base.OnModelCreating(builder);
    }
    
}
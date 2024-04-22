using Microsoft.EntityFrameworkCore;
public class BasicDBContext:DbContext
{
    public DbSet<Teacher> Teachers { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Student.db");
    }
}
using Microsoft.EntityFrameworkCore;
using MvsDatabase.Storage.Entities;

namespace MvsDatabase.Storage;

public class UniverstiyContext:DbContext
{

    public UniverstiyContext(DbContextOptions<UniverstiyContext> options):base(options)
    {
        
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }
}

using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Entities;

namespace RepositoryPattern;

public class RepositoryPatternDbContext(DbContextOptions<RepositoryPatternDbContext> options) : DbContext(options)
{
    public virtual DbSet<BookEntity> Books { get; set; }
    public virtual DbSet<PhoneEntity> Phones { get; set; }
}
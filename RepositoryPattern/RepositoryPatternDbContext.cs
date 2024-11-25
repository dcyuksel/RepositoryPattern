using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Entities;

namespace RepositoryPattern;

public class RepositoryPatternDbContext(DbContextOptions<RepositoryPatternDbContext> options) : DbContext(options)
{
    public virtual required DbSet<BookEntity> Books { get; set; }
    public virtual required DbSet<PhoneEntity> Phones { get; set; }
}
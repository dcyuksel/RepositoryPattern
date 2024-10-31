using System.ComponentModel.DataAnnotations;

namespace RepositoryPattern.Entities;

public abstract class BaseEntity
{
    [Key]
    public long Id { get; set; }
}

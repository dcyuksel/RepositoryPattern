using System.ComponentModel.DataAnnotations.Schema;

namespace RepositoryPattern.Entities;

[Table("Books", Schema = "dbo")]
public class BookEntity : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Author { get; set; } = null!;
    public decimal Price { get; set; }
}

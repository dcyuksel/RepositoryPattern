using System.ComponentModel.DataAnnotations.Schema;

namespace RepositoryPattern.Entities;

[Table("Phones", Schema = "dbo")]
public class PhoneEntity : BaseEntity
{
    public string Brand { get; set; } = null!;
    public string Model { get; set; } = null!;
    public decimal Price { get; set; }
}

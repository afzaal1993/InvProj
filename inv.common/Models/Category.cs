namespace Inv.Common.Models;

public class Category
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public bool IsActive { get; set; } = true;

    //Navigation properties
    public ICollection<Product>? Products { get; set; }
}

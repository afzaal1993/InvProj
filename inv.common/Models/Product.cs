namespace Inv.Common.Models;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int CategoryId { get; set; }
    public int TotalStock { get; set; }
    public bool IsActive { get; set; } = true;

    //Navigation Properties
    public required Category Category { get; set; }
    public ICollection<Batch>? Batches { get; set; }
}

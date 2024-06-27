namespace Inv.Common.Models;

public class Batch
{
    public int Id { get; set; }
    public string? BatchNumber { get; set; }
    public int ProductId { get; set; }
    public int Qty { get; set; }
    public DateTime BatchDate { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public bool IsActive { get; set; } = true;

    //Navigation Properties
    public required Product Product { get; set; }
}

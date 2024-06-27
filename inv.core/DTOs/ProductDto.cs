namespace Inv.Core.DTOs;

public record ProductDto(
    int ProductId,
    string ProductName,
    int TotalStock,
    string BatchNumber,
    DateTime BatchDate,
    DateTime? ExpiryDate,
    string CategoryName
);
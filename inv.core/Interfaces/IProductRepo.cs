using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inv.Core.DTOs;

namespace Inv.Core.Interfaces
{
    public interface IProductRepo
    {
        Task<IEnumerable<ProductDto>> GetAllProducts();
        Task<ProductDto?> GetProductById(int id);
    }
}
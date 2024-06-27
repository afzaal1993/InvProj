using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inv.Core.Data;
using Inv.Core.DTOs;
using Inv.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Inv.Core.Repositories
{
    public class ProductRepo : IProductRepo
    {
        private readonly CoreDbConext _coreDbConext;

        public ProductRepo(CoreDbConext coreDbConext)
        {
            _coreDbConext = coreDbConext;
        }
        public async Task<IEnumerable<ProductDto>> GetAllProducts()
        {
            var query = from product in _coreDbConext.Products
                        join batch in _coreDbConext.Batches on product.Id equals batch.ProductId
                        join category in _coreDbConext.Categories on product.CategoryId equals category.Id
                        select new ProductDto(
                            product.Id,
                            product.Name,
                            product.TotalStock,
                            batch.BatchNumber ?? "",
                            batch.BatchDate,
                            batch.ExpiryDate,
                            category.Name
                        );

            return await query.ToListAsync();
        }

        public async Task<ProductDto?> GetProductById(int id)
        {
            var query = from product in _coreDbConext.Products
                        join batch in _coreDbConext.Batches on product.Id equals batch.ProductId
                        join category in _coreDbConext.Categories on product.CategoryId equals category.Id
                        where product.Id == id
                        select new ProductDto(
                            product.Id,
                            product.Name,
                            product.TotalStock,
                            batch.BatchNumber ?? "",
                            batch.BatchDate,
                            batch.ExpiryDate,
                            category.Name
                        );

            return await query.SingleOrDefaultAsync();
        }
    }
}
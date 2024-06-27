using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inv.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Inv.Core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _unitOfWork.ProductRepo.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("GetById/{id:int}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _unitOfWork.ProductRepo.GetProductById(id);
            if (product == null) return NotFound();

            return Ok(product);
        }
    }
}
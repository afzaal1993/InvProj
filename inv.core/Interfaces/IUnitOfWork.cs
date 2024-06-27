using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inv.Core.Interfaces
{
    public interface IUnitOfWork
    {
        IProductRepo ProductRepo { get; }
        Task<bool> SaveAsync();
    }
}
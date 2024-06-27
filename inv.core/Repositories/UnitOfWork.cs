using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inv.Core.Data;
using Inv.Core.Interfaces;

namespace Inv.Core.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CoreDbConext _coreDbConext;
        private IProductRepo? _productRepo;
        private bool _disposed = false;

        public UnitOfWork(CoreDbConext coreDbConext)
        {
            _coreDbConext = coreDbConext;
        }
        public IProductRepo ProductRepo
        {
            get
            {
                return _productRepo ??= new ProductRepo(_coreDbConext);
            }
        }

        public async Task<bool> SaveAsync()
        {
            return await _coreDbConext.SaveChangesAsync() > 0;
        }
    }
}
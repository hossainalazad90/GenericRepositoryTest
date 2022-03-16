using GenericRepositoryTest.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryTest.GenericRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        public  ApplicationDBContext _context;

        public UnitOfWork(ApplicationDBContext context)
        {
            _context = context;
        }
        public int Commit()
        {
           return _context.SaveChanges();
        }

        public Task<int> CommitAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context !=null)
                {
                    _context.Dispose();
                    _context = null;
                }

            }
        }
        public async Task DisposeAsync()
        {
            await DisposeAsync(true);
            GC.SuppressFinalize(this);
        }
        private async Task DisposeAsync(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                  await  _context.DisposeAsync();
                    _context = null;
                }

            }
        }
    }
}

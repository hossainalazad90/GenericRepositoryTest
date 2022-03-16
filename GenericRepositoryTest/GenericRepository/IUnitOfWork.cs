using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryTest.GenericRepository
{
    public interface IUnitOfWork:IDisposable
    {
        int Commit();
        Task<int>  CommitAsync();
    }
}

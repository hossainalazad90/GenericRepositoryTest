using GenericRepositoryTest.Context;
using GenericRepositoryTest.GenericRepository;
using GenericRepositoryTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryTest.Repositories
{
    interface IEmployeeRepository :IRepository<Employee> 
    {

    }

    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        ApplicationDBContext _dbContext;
        public EmployeeRepository(DbContext context) : base(context)
        {
            _dbContext = (ApplicationDBContext)context;
        }
    }
}

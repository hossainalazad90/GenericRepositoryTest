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
<<<<<<< HEAD
    public interface IEmployeeRepository :IRepository<Employee> 
=======
    interface IEmployeeRepository :IRepository<Employee> 
>>>>>>> 589aa55a0d0e77d9b422d78c02b852c7e43fd259
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

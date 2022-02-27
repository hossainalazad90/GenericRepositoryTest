using GenericRepositoryTest.GenericRepository;
using GenericRepositoryTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryTest.Services
{

    interface IEmployeeService
    {

    }

    public class EmployeeService: IEmployeeService
    {
        IRepository<Employee> _employee;
        public EmployeeService(IRepository<Employee> employee)
        {
            _employee = employee;
        }

    }
}

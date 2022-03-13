using GenericRepositoryTest.GenericRepository;
using GenericRepositoryTest.Models;
using GenericRepositoryTest.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryTest.Services
{


    public interface IEmployeeService
    {
        List<Employee> GetAll();

    }

    public class EmployeeService: IEmployeeService
    {

        IEmployeeRepository _employee;
        public EmployeeService(IEmployeeRepository employee)

        {
            _employee = employee;
        }

        public List<Employee> GetAll()
        {
           return _employee.GetAll().ToList();
        }

    }
}

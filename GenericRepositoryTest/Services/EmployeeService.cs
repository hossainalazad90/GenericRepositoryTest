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
        void Remove(int id);
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

        public void Remove(int id)
        {
            var res = _employee.FirstOrDefault(f => f.Id == id);
            _employee.Delete(res);
            
        }
    }
}

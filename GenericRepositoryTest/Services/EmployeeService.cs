using GenericRepositoryTest.GenericRepository;
using GenericRepositoryTest.Models;
<<<<<<< HEAD
using GenericRepositoryTest.Repositories;
=======
>>>>>>> 589aa55a0d0e77d9b422d78c02b852c7e43fd259
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryTest.Services
{

<<<<<<< HEAD
    public interface IEmployeeService
    {
        List<Employee> GetAll();
=======
    interface IEmployeeService
    {

>>>>>>> 589aa55a0d0e77d9b422d78c02b852c7e43fd259
    }

    public class EmployeeService: IEmployeeService
    {
<<<<<<< HEAD
        IEmployeeRepository _employee;
        public EmployeeService(IEmployeeRepository employee)
=======
        IRepository<Employee> _employee;
        public EmployeeService(IRepository<Employee> employee)
>>>>>>> 589aa55a0d0e77d9b422d78c02b852c7e43fd259
        {
            _employee = employee;
        }

<<<<<<< HEAD
        public List<Employee> GetAll()
        {
           return _employee.GetAll().ToList();
        }
=======
>>>>>>> 589aa55a0d0e77d9b422d78c02b852c7e43fd259
    }
}

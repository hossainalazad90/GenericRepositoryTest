using GenericRepositoryTest.Context;
using GenericRepositoryTest.Models;
<<<<<<< HEAD
using GenericRepositoryTest.Services;
=======
>>>>>>> 589aa55a0d0e77d9b422d78c02b852c7e43fd259
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryTest.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeController
        ApplicationDBContext _applicationDBContext;
<<<<<<< HEAD
        private readonly IEmployeeService _employeeService;

        public EmployeeController(ApplicationDBContext applicationDBContext, IEmployeeService employeeService )
        {
            _applicationDBContext = applicationDBContext;
            _employeeService = employeeService;
        }
        public ActionResult Index()
        {
            //var employeeList= _applicationDBContext.Employees.ToList();

            var employeeList = _employeeService.GetAll();
=======
        public EmployeeController(ApplicationDBContext applicationDBContext)
        {
            _applicationDBContext = applicationDBContext;
        }
        public ActionResult Index()
        {
           var employeeList= _applicationDBContext.Employees.ToList();
>>>>>>> 589aa55a0d0e77d9b422d78c02b852c7e43fd259
            return View(employeeList);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var result = _applicationDBContext.Employees.Find(id);
            return View(result);           
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
                _applicationDBContext.Add(employee);
                _applicationDBContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(employee);
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var result = _applicationDBContext.Employees.Find(id);
            return View(result);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            try
            {
                _applicationDBContext.Update(employee);
                _applicationDBContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(employee);
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var result = _applicationDBContext.Employees.Find(id);
            return View(result);            
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _applicationDBContext.Remove(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepositoryPattern.Models;
using RepositoryPattern.Repository.Interfaces;

namespace RepositoryPattern.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository context;

        public EmployeeController(IEmployeeRepository _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            var model = context.GetAll();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            context.Insert(employee);
            context.Save();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            var model = context.GetById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            context.Update(employee);
            context.Save();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            var model = context.GetById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult DeleteConfirmed(Employee employee)
        {
            context.Delete(employee);
            context.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}
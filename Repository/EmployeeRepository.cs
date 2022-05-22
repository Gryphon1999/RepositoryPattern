using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryPattern.DAL;
using RepositoryPattern.Models;
using RepositoryPattern.Repository.Interfaces;

namespace RepositoryPattern.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly RepoDbContext context;

        public EmployeeRepository(RepoDbContext _context)
        {
            context = _context;
        }
        public void Delete(Employee employee)
        {
            context.employees.Remove(employee);
        }

        public IEnumerable<Employee> GetAll()
        {
            return context.employees.ToList();
        }

        public Employee GetById(int id)
        {
            var data = context.employees.Find(id);
            return data;
        }

        public void Insert(Employee employee)
        {
            context.employees.Add(employee);
        }

        public void Update(Employee employee)
        {
            context.employees.Update(employee);
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
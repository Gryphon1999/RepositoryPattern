using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryPattern.Models;

namespace RepositoryPattern.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee>GetAll();
        Employee GetById(int id);
        void Insert (Employee employee);
        void Update (Employee employee);
        void Delete (Employee employee);
        void Save();
    }
}
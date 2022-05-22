using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Models;

namespace RepositoryPattern.DAL
{
    public class RepoDbContext:DbContext
    {
        public RepoDbContext(DbContextOptions<RepoDbContext>options):base(options)
        {
            
        }
        public DbSet<Employee> employees{get;set;}
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPIProject.Models;

namespace WebAPIProject.Data
{
    public class Context:DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
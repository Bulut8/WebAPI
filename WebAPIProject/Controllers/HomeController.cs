using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIProject.Data;
using WebAPIProject.Models;

namespace WebAPIProject.Controllers
{
    public class HomeController : ApiController
    {
        Context db = new Context();
        [HttpGet]
        public IEnumerable<Employee> Employees()
        {
            return db.Employee.Where(w=>w.Department=="Depo").ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TokenAithApi2.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<Employee> GetEmployees()
        {
            using (Test2Entities _db = new Test2Entities())
            {
                return _db.Employees.ToList();
            }
        }
    }
}

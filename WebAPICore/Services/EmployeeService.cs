using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.IServices;
using WebAPICore.Models;

namespace WebAPICore.Services
{
    public class EmployeeService : IEmployeeService
    {
        APICoreDBContext dbContext;
        public EmployeeService(APICoreDBContext _db)
        {
            dbContext = _db;
        }
        public List<Employee> GetEmployee()
        {
            var employee = dbContext.Employees.ToList();
            return employee;
        }
    }
}

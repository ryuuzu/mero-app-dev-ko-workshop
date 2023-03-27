using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.Application.Common.Interface;
using workshop.Application.DTOs;
using workshop.Domain.Entities;

namespace workshop.Infrastructure.Services
{
    public class EmployeeDetails : IEmployeeDetails
    {
        private readonly IApplicationDBContext _dbContext;

        public EmployeeDetails(IApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Employee> AddEmployeeDetails(EmployeeRequestDTO employee)
        {
            throw new NotImplementedException();
        }
    }
}

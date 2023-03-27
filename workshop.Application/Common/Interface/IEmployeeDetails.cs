using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.Application.DTOs;
using workshop.Domain.Entities;

namespace workshop.Application.Common.Interface
{
    public interface IEmployeeDetails
    {
        Task<Employee> AddEmployeeDetails(EmployeeRequestDTO employee);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.Application.DTOs
{
    public class EmployeeRequestDTO
    {
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public double Salary { get; set; }
        public string Contact { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.Domain.Entities;

namespace workshop.Application.Common.Interface
{
    public interface IApplicationDBContext
    {
        DbSet<Employee> Employee { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.Domain.Shared;

namespace workshop.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();

    }
}

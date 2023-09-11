using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BasicStudentDatabase1.Models;

namespace BasicStudentDatabase1.Data
{
    public class BasicStudentDatabase1Context : DbContext
    {
        public BasicStudentDatabase1Context (DbContextOptions<BasicStudentDatabase1Context> options)
            : base(options)
        {
        }

        public DbSet<BasicStudentDatabase1.Models.StudentApp> StudentApp { get; set; } = default!;
    }
}

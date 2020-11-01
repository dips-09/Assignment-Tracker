using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentTraker_HW5.Models
{
    public class AssignmentContext : DbContext
    {
        public AssignmentContext(DbContextOptions<AssignmentContext> options) : base(options)
        {

        }


        public DbSet<ClsAssignment> Assignments{get;set;}

    }
}

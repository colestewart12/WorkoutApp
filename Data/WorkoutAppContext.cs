using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkoutApp.Models;

namespace WorkoutApp.Data
{
    public class WorkoutAppContext : DbContext
    {
        public WorkoutAppContext (DbContextOptions<WorkoutAppContext> options)
            : base(options)
        {
        }

        public DbSet<WorkoutApp.Models.Exercise> Exercise { get; set; } = default!;
    }
}

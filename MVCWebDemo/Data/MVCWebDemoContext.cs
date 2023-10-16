using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCWebDemo.Models;

namespace MVCWebDemo.Data
{
    public class MVCWebDemoContext : DbContext
    {
        public MVCWebDemoContext (DbContextOptions<MVCWebDemoContext> options)
            : base(options)
        {
        }

        public DbSet<MVCWebDemo.Models.User> User { get; set; } = default!;
    }
}

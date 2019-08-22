using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AngularCrud.Models;

namespace AngularCrud.Models
{
    public class AngularCrudContext : DbContext
    {
        public AngularCrudContext (DbContextOptions<AngularCrudContext> options)
            : base(options)
        {
        }

        public DbSet<AngularCrud.Models.TblCities> TblCities { get; set; }

        public DbSet<AngularCrud.Models.TblEmployee> TblEmployee { get; set; }
    }
}

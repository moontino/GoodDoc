using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodDoc_BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace GoodDoc_BackEnd.Data
{
    public class GoodDocDbContext : DbContext
    {
        public GoodDocDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Test> Test { get; set; }
    }
}
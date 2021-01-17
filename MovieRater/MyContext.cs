using Microsoft.EntityFrameworkCore;
using MovieRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRater
{
    public class MyContext : DbContext
    {
            public MyContext(DbContextOptions<MyContext> options) : base(options) { }
            public virtual DbSet<Film> Films { get; set; }       
    }
}

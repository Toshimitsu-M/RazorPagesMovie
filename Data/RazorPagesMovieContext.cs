using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //  UseInternalServiceProvider(IServiceProvider serviceProvider);
       　// optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test");
        //}

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }


    }
}

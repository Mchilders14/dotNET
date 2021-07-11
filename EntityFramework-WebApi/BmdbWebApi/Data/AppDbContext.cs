using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BmdbWebApi.Models;

namespace BmDbWebApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<BmdbWebApi.Models.Actor> Actors { get; set; }
        public DbSet<BmdbWebApi.Models.Movie> Movies { get; set; }
        public DbSet<BmdbWebApi.Models.Credit> Credits { get; set; }
        public DbSet<BmdbWebApi.Models.User> Users { get; set; }
        public DbSet<BmdbWebApi.Models.MovieCollection> MovieCollections { get; set; }
    }
}

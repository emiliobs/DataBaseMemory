using DataBaseMemory.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseMemory.DataContext
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options):base(options)
        {

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artista> Artistas { get; set; }
    }
}

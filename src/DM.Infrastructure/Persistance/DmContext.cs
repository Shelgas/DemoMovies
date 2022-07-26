﻿global using DM.Domain.Interfaces;
global using DM.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM.Infrastructure.Persistance
{
    internal class DmContext : DbContext
    {
        public DmContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Actor>? Actors { get; set; }
        public DbSet<Movie>? Movies { get; set; }
    }
}

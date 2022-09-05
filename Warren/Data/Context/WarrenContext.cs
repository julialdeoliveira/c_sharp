﻿using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.NovaPasta
{
  public class WarrenContext : DbContext
    {
        #region Prop
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Planta> Planta { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Categoria>Categoria { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=192.168.0.138; Port=5436; Database=postgres; UserId=postgres; Password=123456");
        }
    }
}


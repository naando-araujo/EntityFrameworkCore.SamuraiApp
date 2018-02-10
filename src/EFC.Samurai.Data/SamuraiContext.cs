﻿using EFC.SamuraiApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFC.SamuraiApp.Data
{
    public class SamuraiContext : DbContext
    {
        #region Ctor

        public SamuraiContext(DbContextOptions<SamuraiContext> options)
            : base(options)
        { }

        #endregion Ctor


        #region DbSets

        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Battle> Battles { get; set; }

        #endregion DbSets


        #region Override Methods

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //base.OnConfiguring(optionsBuilder);

        //    var connStr = "Server=(localdb)\\mssqllocaldb; Database=SamuraiAppCore; Trusted_Connection=True;";
        //    optionsBuilder.UseSqlServer(connStr);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamuraiBattle>()
                .HasKey(s => new { s.SamuraiId, s.BattleId });
        }

        #endregion Override Methods
    }
}

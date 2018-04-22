﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AngularEf.Models
{
    public partial class AngularEfContext : DbContext
    {
        public virtual DbSet<Member> Member { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=AngularEf;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gender).HasColumnType("nchar(10)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.Phone).HasMaxLength(50);
            });
        }
    }
}

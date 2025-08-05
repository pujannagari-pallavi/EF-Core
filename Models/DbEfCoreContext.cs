using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DbFirst.Models;

public partial class DbEfCoreContext : DbContext
{
    public DbEfCoreContext()
    {
    }

    public DbEfCoreContext(DbContextOptions<DbEfCoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
#warning

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustId);

            entity.ToTable("Customer");

            entity.Property(e => e.CustId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("cust_id");
            entity.Property(e => e.CustAge)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("cust_age");
            entity.Property(e => e.CustName)
                .HasMaxLength(50)
                .HasColumnName("cust_name");
            entity.Property(e => e.CustPhone)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("cust_phone");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace practicaParcial2.EF;

public partial class MiDBContext : DbContext
{
    public MiDBContext(DbContextOptions<MiDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PRIMARY");

            entity.ToTable("orders");

            entity.Property(e => e.OrderId).HasColumnName("orderId");
            entity.Property(e => e.OrderAmount).HasColumnName("orderAmount");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(250)
                .HasColumnName("orderNumber");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("users");

            entity.Property(e => e.Dni)
                .HasMaxLength(250)
                .HasColumnName("DNI");
            entity.Property(e => e.Firstname).HasMaxLength(250);
            entity.Property(e => e.Lastname).HasMaxLength(250);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

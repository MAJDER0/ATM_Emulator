using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ATM_Emulator.Enitites;

public partial class AtmContext : DbContext
{
    public AtmContext()
    {
    }

    public AtmContext(DbContextOptions<AtmContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Login> Logins { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=XXX\\SQLEXPRESS;Database=ATM;Encrypt=False;Trusted_Connection=True;");
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Login>(entity =>
        {
            entity.HasKey(e => e.ID);

            entity.ToTable("login");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");

            entity.HasIndex(e => e.Username).IsUnique(true);




        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

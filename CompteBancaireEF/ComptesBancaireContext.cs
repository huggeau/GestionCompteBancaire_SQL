using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CompteBancaireEF;

public partial class ComptesBancaireContext : DbContext
{
    public ComptesBancaireContext()
    {
    }

    public ComptesBancaireContext(DbContextOptions<ComptesBancaireContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Compte> Comptes { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("data source=ComptesBancaire.sqlite");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Compte>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Proprietaire).HasColumnName("proprietaire");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.IdCompte).HasColumnName("idCompte");
            entity.Property(e => e.Montant).HasColumnName("montant");
            entity.Property(e => e.Notes).HasColumnName("notes");

            entity.HasOne(d => d.IdCompteNavigation).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.IdCompte)
                .OnDelete(DeleteBehavior.Restrict);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

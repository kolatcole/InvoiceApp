using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace InvoiceApp.Core.Model
{
    public partial class InvoiceDBContext : DbContext
    {
        public InvoiceDBContext()
        {
        }

        public InvoiceDBContext(DbContextOptions<InvoiceDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Invoice> Invoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-56E2M3M;Initial Catalog=InvoiceDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("Invoice");

                entity.Property(e => e.Amount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Client)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryDate).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExchangeRate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalesAgent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SettleDate).HasColumnType("date");

                entity.Property(e => e.Vat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VAT");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

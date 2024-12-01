using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using for_hack_fic.Db.Models;

namespace for_hack_fic.Db.DbConnector;

public partial class HackForFicDbContext : DbContext
{
    public HackForFicDbContext()
    {
    }

    public HackForFicDbContext(DbContextOptions<HackForFicDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=83.147.246.87;Database=hack_for_fic_db;Username=hack_for_fic_user;Password=12345;Port=5432");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("products_pkey");

            entity.ToTable("products");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BarcodeEan128)
                .HasMaxLength(500)
                .HasColumnName("barcode_ean_128");
            entity.Property(e => e.BarcodeEan13)
                .HasMaxLength(500)
                .HasColumnName("barcode_ean_13");
            entity.Property(e => e.CompositionRu)
                .HasMaxLength(500)
                .HasColumnName("composition_ru");
            entity.Property(e => e.CountryOfOrigin)
                .HasMaxLength(500)
                .HasColumnName("country_of_origin");
            entity.Property(e => e.DomesticSize)
                .HasMaxLength(500)
                .HasColumnName("domestic_size");
            entity.Property(e => e.ImporterRf).HasColumnName("importer_rf");
            entity.Property(e => e.ManufactureDate)
                .HasMaxLength(500)
                .HasColumnName("manufacture_date");
            entity.Property(e => e.ManufacturerName).HasColumnName("manufacturer_name");
            entity.Property(e => e.ManufacturerSize)
                .HasMaxLength(500)
                .HasColumnName("manufacturer_size");
            entity.Property(e => e.Model)
                .HasMaxLength(500)
                .HasColumnName("model");
            entity.Property(e => e.NameRu)
                .HasMaxLength(500)
                .HasColumnName("name_ru");
            entity.Property(e => e.ProducerAddress).HasColumnName("producer_address");
            entity.Property(e => e.ProducerName).HasColumnName("producer_name");
            entity.Property(e => e.RetailPrice)
                .HasPrecision(10, 2)
                .HasColumnName("retail_price");
            entity.Property(e => e.SupplyNumber)
                .HasMaxLength(500)
                .HasColumnName("supply_number");
            entity.Property(e => e.TypeSign)
                .HasMaxLength(500)
                .HasColumnName("type_sign");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

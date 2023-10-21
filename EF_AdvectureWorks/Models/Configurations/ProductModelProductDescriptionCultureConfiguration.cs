﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EF_AdvectureWorks.Models;
using EF_AdvectureWorks.Models.dboSchema;
using EF_AdvectureWorks.Models.HumanResourcesSchema;
using EF_AdvectureWorks.Models.PersonSchema;
using EF_AdvectureWorks.Models.ProductionSchema;
using EF_AdvectureWorks.Models.PurchasingSchema;
using EF_AdvectureWorks.Models.SalesSchema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

#nullable disable

namespace EF_AdvectureWorks.Models.Configurations
{
    public partial class ProductModelProductDescriptionCultureConfiguration : IEntityTypeConfiguration<ProductModelProductDescriptionCulture>
    {
        public void Configure(EntityTypeBuilder<ProductModelProductDescriptionCulture> entity)
        {
            entity.HasKey(e => new { e.ProductModelId, e.ProductDescriptionId, e.CultureId }).HasName("PK_ProductModelProductDescriptionCulture_ProductModelID_ProductDescriptionID_CultureID");

            entity.ToTable("ProductModelProductDescriptionCulture", "Production", tb => tb.HasComment("Cross-reference table mapping product descriptions and the language the description is written in."));

            entity.Property(e => e.ProductModelId)
            .HasComment("Primary key. Foreign key to ProductModel.ProductModelID.")
            .HasColumnName("ProductModelID");
            entity.Property(e => e.ProductDescriptionId)
            .HasComment("Primary key. Foreign key to ProductDescription.ProductDescriptionID.")
            .HasColumnName("ProductDescriptionID");
            entity.Property(e => e.CultureId)
            .HasMaxLength(6)
            .IsFixedLength()
            .HasComment("Culture identification number. Foreign key to Culture.CultureID.")
            .HasColumnName("CultureID");
            entity.Property(e => e.ModifiedDate)
            .HasDefaultValueSql("(getdate())")
            .HasComment("Date and time the record was last updated.")
            .HasColumnType("datetime");

            entity.HasOne(d => d.Culture).WithMany(p => p.ProductModelProductDescriptionCulture)
            .HasForeignKey(d => d.CultureId)
            .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ProductDescription).WithMany(p => p.ProductModelProductDescriptionCulture)
            .HasForeignKey(d => d.ProductDescriptionId)
            .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ProductModel).WithMany(p => p.ProductModelProductDescriptionCulture)
            .HasForeignKey(d => d.ProductModelId)
            .OnDelete(DeleteBehavior.ClientSetNull);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ProductModelProductDescriptionCulture> entity);
    }
}
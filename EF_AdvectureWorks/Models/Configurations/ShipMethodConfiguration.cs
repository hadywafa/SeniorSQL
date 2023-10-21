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
    public partial class ShipMethodConfiguration : IEntityTypeConfiguration<ShipMethod>
    {
        public void Configure(EntityTypeBuilder<ShipMethod> entity)
        {
            entity.HasKey(e => e.ShipMethodId).HasName("PK_ShipMethod_ShipMethodID");

            entity.ToTable("ShipMethod", "Purchasing", tb => tb.HasComment("Shipping company lookup table."));

            entity.HasIndex(e => e.Name, "AK_ShipMethod_Name").IsUnique();

            entity.HasIndex(e => e.Rowguid, "AK_ShipMethod_rowguid").IsUnique();

            entity.Property(e => e.ShipMethodId)
            .HasComment("Primary key for ShipMethod records.")
            .HasColumnName("ShipMethodID");
            entity.Property(e => e.ModifiedDate)
            .HasDefaultValueSql("(getdate())")
            .HasComment("Date and time the record was last updated.")
            .HasColumnType("datetime");
            entity.Property(e => e.Name)
            .HasMaxLength(50)
            .HasComment("Shipping company name.");
            entity.Property(e => e.Rowguid)
            .HasDefaultValueSql("(newid())")
            .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.")
            .HasColumnName("rowguid");
            entity.Property(e => e.ShipBase)
            .HasDefaultValueSql("((0.00))")
            .HasComment("Minimum shipping charge.")
            .HasColumnType("money");
            entity.Property(e => e.ShipRate)
            .HasDefaultValueSql("((0.00))")
            .HasComment("Shipping charge per pound.")
            .HasColumnType("money");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ShipMethod> entity);
    }
}

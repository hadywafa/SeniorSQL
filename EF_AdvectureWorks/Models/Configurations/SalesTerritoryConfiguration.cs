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
    public partial class SalesTerritoryConfiguration : IEntityTypeConfiguration<SalesTerritory>
    {
        public void Configure(EntityTypeBuilder<SalesTerritory> entity)
        {
            entity.HasKey(e => e.TerritoryId).HasName("PK_SalesTerritory_TerritoryID");

            entity.ToTable("SalesTerritory", "Sales", tb => tb.HasComment("Sales territory lookup table."));

            entity.HasIndex(e => e.Name, "AK_SalesTerritory_Name").IsUnique();

            entity.HasIndex(e => e.Rowguid, "AK_SalesTerritory_rowguid").IsUnique();

            entity.Property(e => e.TerritoryId)
            .HasComment("Primary key for SalesTerritory records.")
            .HasColumnName("TerritoryID");
            entity.Property(e => e.CostLastYear)
            .HasDefaultValueSql("((0.00))")
            .HasComment("Business costs in the territory the previous year.")
            .HasColumnType("money");
            entity.Property(e => e.CostYtd)
            .HasDefaultValueSql("((0.00))")
            .HasComment("Business costs in the territory year to date.")
            .HasColumnType("money")
            .HasColumnName("CostYTD");
            entity.Property(e => e.CountryRegionCode)
            .HasMaxLength(3)
            .HasComment("ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode. ");
            entity.Property(e => e.Group)
            .HasMaxLength(50)
            .HasComment("Geographic area to which the sales territory belong.");
            entity.Property(e => e.ModifiedDate)
            .HasDefaultValueSql("(getdate())")
            .HasComment("Date and time the record was last updated.")
            .HasColumnType("datetime");
            entity.Property(e => e.Name)
            .HasMaxLength(50)
            .HasComment("Sales territory description");
            entity.Property(e => e.Rowguid)
            .HasDefaultValueSql("(newid())")
            .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.")
            .HasColumnName("rowguid");
            entity.Property(e => e.SalesLastYear)
            .HasDefaultValueSql("((0.00))")
            .HasComment("Sales in the territory the previous year.")
            .HasColumnType("money");
            entity.Property(e => e.SalesYtd)
            .HasDefaultValueSql("((0.00))")
            .HasComment("Sales in the territory year to date.")
            .HasColumnType("money")
            .HasColumnName("SalesYTD");

            entity.HasOne(d => d.CountryRegionCodeNavigation).WithMany(p => p.SalesTerritory)
            .HasForeignKey(d => d.CountryRegionCode)
            .OnDelete(DeleteBehavior.ClientSetNull);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SalesTerritory> entity);
    }
}

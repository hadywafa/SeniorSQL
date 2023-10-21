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
    public partial class SalesTerritoryHistoryConfiguration : IEntityTypeConfiguration<SalesTerritoryHistory>
    {
        public void Configure(EntityTypeBuilder<SalesTerritoryHistory> entity)
        {
            entity.HasKey(e => new { e.BusinessEntityId, e.StartDate, e.TerritoryId }).HasName("PK_SalesTerritoryHistory_BusinessEntityID_StartDate_TerritoryID");

            entity.ToTable("SalesTerritoryHistory", "Sales", tb => tb.HasComment("Sales representative transfers to other sales territories."));

            entity.HasIndex(e => e.Rowguid, "AK_SalesTerritoryHistory_rowguid").IsUnique();

            entity.Property(e => e.BusinessEntityId)
            .HasComment("Primary key. The sales rep.  Foreign key to SalesPerson.BusinessEntityID.")
            .HasColumnName("BusinessEntityID");
            entity.Property(e => e.StartDate)
            .HasComment("Primary key. Date the sales representive started work in the territory.")
            .HasColumnType("datetime");
            entity.Property(e => e.TerritoryId)
            .HasComment("Primary key. Territory identification number. Foreign key to SalesTerritory.SalesTerritoryID.")
            .HasColumnName("TerritoryID");
            entity.Property(e => e.EndDate)
            .HasComment("Date the sales representative left work in the territory.")
            .HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate)
            .HasDefaultValueSql("(getdate())")
            .HasComment("Date and time the record was last updated.")
            .HasColumnType("datetime");
            entity.Property(e => e.Rowguid)
            .HasDefaultValueSql("(newid())")
            .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.")
            .HasColumnName("rowguid");

            entity.HasOne(d => d.BusinessEntity).WithMany(p => p.SalesTerritoryHistory)
            .HasForeignKey(d => d.BusinessEntityId)
            .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Territory).WithMany(p => p.SalesTerritoryHistory)
            .HasForeignKey(d => d.TerritoryId)
            .OnDelete(DeleteBehavior.ClientSetNull);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<SalesTerritoryHistory> entity);
    }
}

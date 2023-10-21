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
    public partial class AddressTypeConfiguration : IEntityTypeConfiguration<AddressType>
    {
        public void Configure(EntityTypeBuilder<AddressType> entity)
        {
            entity.HasKey(e => e.AddressTypeId).HasName("PK_AddressType_AddressTypeID");

            entity.ToTable("AddressType", "Person", tb => tb.HasComment("Types of addresses stored in the Address table. "));

            entity.HasIndex(e => e.Name, "AK_AddressType_Name").IsUnique();

            entity.HasIndex(e => e.Rowguid, "AK_AddressType_rowguid").IsUnique();

            entity.Property(e => e.AddressTypeId)
            .HasComment("Primary key for AddressType records.")
            .HasColumnName("AddressTypeID");
            entity.Property(e => e.ModifiedDate)
            .HasDefaultValueSql("(getdate())")
            .HasComment("Date and time the record was last updated.")
            .HasColumnType("datetime");
            entity.Property(e => e.Name)
            .HasMaxLength(50)
            .HasComment("Address type description. For example, Billing, Home, or Shipping.");
            entity.Property(e => e.Rowguid)
            .HasDefaultValueSql("(newid())")
            .HasComment("ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.")
            .HasColumnName("rowguid");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<AddressType> entity);
    }
}
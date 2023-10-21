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
    public partial class VProductModelInstructionsConfiguration : IEntityTypeConfiguration<VProductModelInstructions>
    {
        public void Configure(EntityTypeBuilder<VProductModelInstructions> entity)
        {
            entity
            .HasNoKey()
            .ToView("vProductModelInstructions", "Production");

            entity.Property(e => e.LaborHours).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.MachineHours).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ProductModelId)
            .ValueGeneratedOnAdd()
            .HasColumnName("ProductModelID");
            entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            entity.Property(e => e.SetupHours).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.Step).HasMaxLength(1024);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VProductModelInstructions> entity);
    }
}

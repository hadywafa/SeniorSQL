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
    public partial class WorkOrderRoutingConfiguration : IEntityTypeConfiguration<WorkOrderRouting>
    {
        public void Configure(EntityTypeBuilder<WorkOrderRouting> entity)
        {
            entity.HasKey(e => new { e.WorkOrderId, e.ProductId, e.OperationSequence }).HasName("PK_WorkOrderRouting_WorkOrderID_ProductID_OperationSequence");

            entity.ToTable("WorkOrderRouting", "Production", tb => tb.HasComment("Work order details."));

            entity.HasIndex(e => e.ProductId, "IX_WorkOrderRouting_ProductID");

            entity.Property(e => e.WorkOrderId)
            .HasComment("Primary key. Foreign key to WorkOrder.WorkOrderID.")
            .HasColumnName("WorkOrderID");
            entity.Property(e => e.ProductId)
            .HasComment("Primary key. Foreign key to Product.ProductID.")
            .HasColumnName("ProductID");
            entity.Property(e => e.OperationSequence).HasComment("Primary key. Indicates the manufacturing process sequence.");
            entity.Property(e => e.ActualCost)
            .HasComment("Actual manufacturing cost.")
            .HasColumnType("money");
            entity.Property(e => e.ActualEndDate)
            .HasComment("Actual end date.")
            .HasColumnType("datetime");
            entity.Property(e => e.ActualResourceHrs)
            .HasComment("Number of manufacturing hours used.")
            .HasColumnType("decimal(9, 4)");
            entity.Property(e => e.ActualStartDate)
            .HasComment("Actual start date.")
            .HasColumnType("datetime");
            entity.Property(e => e.LocationId)
            .HasComment("Manufacturing location where the part is processed. Foreign key to Location.LocationID.")
            .HasColumnName("LocationID");
            entity.Property(e => e.ModifiedDate)
            .HasDefaultValueSql("(getdate())")
            .HasComment("Date and time the record was last updated.")
            .HasColumnType("datetime");
            entity.Property(e => e.PlannedCost)
            .HasComment("Estimated manufacturing cost.")
            .HasColumnType("money");
            entity.Property(e => e.ScheduledEndDate)
            .HasComment("Planned manufacturing end date.")
            .HasColumnType("datetime");
            entity.Property(e => e.ScheduledStartDate)
            .HasComment("Planned manufacturing start date.")
            .HasColumnType("datetime");

            entity.HasOne(d => d.Location).WithMany(p => p.WorkOrderRouting)
            .HasForeignKey(d => d.LocationId)
            .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.WorkOrderRouting)
            .HasForeignKey(d => d.WorkOrderId)
            .OnDelete(DeleteBehavior.ClientSetNull);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<WorkOrderRouting> entity);
    }
}

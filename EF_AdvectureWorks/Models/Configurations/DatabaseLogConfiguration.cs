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
    public partial class DatabaseLogConfiguration : IEntityTypeConfiguration<DatabaseLog>
    {
        public void Configure(EntityTypeBuilder<DatabaseLog> entity)
        {
            entity.HasKey(e => e.DatabaseLogId)
            .HasName("PK_DatabaseLog_DatabaseLogID")
            .IsClustered(false);

            entity.ToTable(tb => tb.HasComment("Audit table tracking all DDL changes made to the AdventureWorks database. Data is captured by the database trigger ddlDatabaseTriggerLog."));

            entity.Property(e => e.DatabaseLogId)
            .HasComment("Primary key for DatabaseLog records.")
            .HasColumnName("DatabaseLogID");
            entity.Property(e => e.DatabaseUser)
            .HasMaxLength(128)
            .HasComment("The user who implemented the DDL change.");
            entity.Property(e => e.Event)
            .HasMaxLength(128)
            .HasComment("The type of DDL statement that was executed.");
            entity.Property(e => e.Object)
            .HasMaxLength(128)
            .HasComment("The object that was changed by the DDL statment.");
            entity.Property(e => e.PostTime)
            .HasComment("The date and time the DDL change occurred.")
            .HasColumnType("datetime");
            entity.Property(e => e.Schema)
            .HasMaxLength(128)
            .HasComment("The schema to which the changed object belongs.");
            entity.Property(e => e.Tsql)
            .HasComment("The exact Transact-SQL statement that was executed.")
            .HasColumnName("TSQL");
            entity.Property(e => e.XmlEvent)
            .HasComment("The raw XML data generated by database trigger.")
            .HasColumnType("xml");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DatabaseLog> entity);
    }
}

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
    public partial class VJobCandidateEducationConfiguration : IEntityTypeConfiguration<VJobCandidateEducation>
    {
        public void Configure(EntityTypeBuilder<VJobCandidateEducation> entity)
        {
            entity
            .HasNoKey()
            .ToView("vJobCandidateEducation", "HumanResources");

            entity.Property(e => e.EduDegree)
            .HasMaxLength(50)
            .HasColumnName("Edu.Degree");
            entity.Property(e => e.EduEndDate)
            .HasColumnType("datetime")
            .HasColumnName("Edu.EndDate");
            entity.Property(e => e.EduGpa)
            .HasMaxLength(5)
            .HasColumnName("Edu.GPA");
            entity.Property(e => e.EduGpascale)
            .HasMaxLength(5)
            .HasColumnName("Edu.GPAScale");
            entity.Property(e => e.EduLevel).HasColumnName("Edu.Level");
            entity.Property(e => e.EduLocCity)
            .HasMaxLength(100)
            .HasColumnName("Edu.Loc.City");
            entity.Property(e => e.EduLocCountryRegion)
            .HasMaxLength(100)
            .HasColumnName("Edu.Loc.CountryRegion");
            entity.Property(e => e.EduLocState)
            .HasMaxLength(100)
            .HasColumnName("Edu.Loc.State");
            entity.Property(e => e.EduMajor)
            .HasMaxLength(50)
            .HasColumnName("Edu.Major");
            entity.Property(e => e.EduMinor)
            .HasMaxLength(50)
            .HasColumnName("Edu.Minor");
            entity.Property(e => e.EduSchool)
            .HasMaxLength(100)
            .HasColumnName("Edu.School");
            entity.Property(e => e.EduStartDate)
            .HasColumnType("datetime")
            .HasColumnName("Edu.StartDate");
            entity.Property(e => e.JobCandidateId)
            .ValueGeneratedOnAdd()
            .HasColumnName("JobCandidateID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VJobCandidateEducation> entity);
    }
}

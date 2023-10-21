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
    public partial class VVendorWithContactsConfiguration : IEntityTypeConfiguration<VVendorWithContacts>
    {
        public void Configure(EntityTypeBuilder<VVendorWithContacts> entity)
        {
            entity
            .HasNoKey()
            .ToView("vVendorWithContacts", "Purchasing");

            entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");
            entity.Property(e => e.ContactType).HasMaxLength(50);
            entity.Property(e => e.EmailAddress).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(25);
            entity.Property(e => e.PhoneNumberType).HasMaxLength(50);
            entity.Property(e => e.Suffix).HasMaxLength(10);
            entity.Property(e => e.Title).HasMaxLength(8);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VVendorWithContacts> entity);
    }
}
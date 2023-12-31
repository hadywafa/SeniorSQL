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
    public partial class VIndividualCustomerConfiguration : IEntityTypeConfiguration<VIndividualCustomer>
    {
        public void Configure(EntityTypeBuilder<VIndividualCustomer> entity)
        {
            entity
            .HasNoKey()
            .ToView("vIndividualCustomer", "Sales");

            entity.Property(e => e.AddressLine1).HasMaxLength(60);
            entity.Property(e => e.AddressLine2).HasMaxLength(60);
            entity.Property(e => e.AddressType).HasMaxLength(50);
            entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");
            entity.Property(e => e.City).HasMaxLength(30);
            entity.Property(e => e.CountryRegionName).HasMaxLength(50);
            entity.Property(e => e.Demographics).HasColumnType("xml");
            entity.Property(e => e.EmailAddress).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(25);
            entity.Property(e => e.PhoneNumberType).HasMaxLength(50);
            entity.Property(e => e.PostalCode).HasMaxLength(15);
            entity.Property(e => e.StateProvinceName).HasMaxLength(50);
            entity.Property(e => e.Suffix).HasMaxLength(10);
            entity.Property(e => e.Title).HasMaxLength(8);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<VIndividualCustomer> entity);
    }
}

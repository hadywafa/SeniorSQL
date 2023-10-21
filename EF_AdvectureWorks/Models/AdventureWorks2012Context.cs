﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EF_AdvectureWorks.Models.Configurations;
using EF_AdvectureWorks.Models.dboSchema;
using EF_AdvectureWorks.Models.HumanResourcesSchema;
using EF_AdvectureWorks.Models.PersonSchema;
using EF_AdvectureWorks.Models.ProductionSchema;
using EF_AdvectureWorks.Models.PurchasingSchema;
using EF_AdvectureWorks.Models.SalesSchema;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
#nullable enable

namespace EF_AdvectureWorks.Models;

public partial class AdventureWorks2012Context : DbContext
{
    public AdventureWorks2012Context()
    {
    }

    public AdventureWorks2012Context(DbContextOptions<AdventureWorks2012Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Address { get; set; }

    public virtual DbSet<AddressType> AddressType { get; set; }

    public virtual DbSet<AwbuildVersion> AwbuildVersion { get; set; }

    public virtual DbSet<BillOfMaterials> BillOfMaterials { get; set; }

    public virtual DbSet<BusinessEntity> BusinessEntity { get; set; }

    public virtual DbSet<BusinessEntityAddress> BusinessEntityAddress { get; set; }

    public virtual DbSet<BusinessEntityContact> BusinessEntityContact { get; set; }

    public virtual DbSet<ContactType> ContactType { get; set; }

    public virtual DbSet<CountryRegion> CountryRegion { get; set; }

    public virtual DbSet<CountryRegionCurrency> CountryRegionCurrency { get; set; }

    public virtual DbSet<CreditCard> CreditCard { get; set; }

    public virtual DbSet<Culture> Culture { get; set; }

    public virtual DbSet<Currency> Currency { get; set; }

    public virtual DbSet<CurrencyRate> CurrencyRate { get; set; }

    public virtual DbSet<Customer> Customer { get; set; }

    public virtual DbSet<DatabaseLog> DatabaseLog { get; set; }

    public virtual DbSet<Department> Department { get; set; }

    public virtual DbSet<EmailAddress> EmailAddress { get; set; }

    public virtual DbSet<Employee> Employee { get; set; }

    public virtual DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }

    public virtual DbSet<EmployeePayHistory> EmployeePayHistory { get; set; }

    public virtual DbSet<ErrorLog> ErrorLog { get; set; }

    public virtual DbSet<Illustration> Illustration { get; set; }

    public virtual DbSet<JobCandidate> JobCandidate { get; set; }

    public virtual DbSet<Location> Location { get; set; }

    public virtual DbSet<Password> Password { get; set; }

    public virtual DbSet<Person> Person { get; set; }

    public virtual DbSet<PersonCreditCard> PersonCreditCard { get; set; }

    public virtual DbSet<PersonPhone> PersonPhone { get; set; }

    public virtual DbSet<PhoneNumberType> PhoneNumberType { get; set; }

    public virtual DbSet<Product> Product { get; set; }

    public virtual DbSet<ProductCategory> ProductCategory { get; set; }

    public virtual DbSet<ProductCostHistory> ProductCostHistory { get; set; }

    public virtual DbSet<ProductDescription> ProductDescription { get; set; }

    public virtual DbSet<ProductInventory> ProductInventory { get; set; }

    public virtual DbSet<ProductListPriceHistory> ProductListPriceHistory { get; set; }

    public virtual DbSet<ProductModel> ProductModel { get; set; }

    public virtual DbSet<ProductModelIllustration> ProductModelIllustration { get; set; }

    public virtual DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; }

    public virtual DbSet<ProductPhoto> ProductPhoto { get; set; }

    public virtual DbSet<ProductProductPhoto> ProductProductPhoto { get; set; }

    public virtual DbSet<ProductReview> ProductReview { get; set; }

    public virtual DbSet<ProductSubcategory> ProductSubcategory { get; set; }

    public virtual DbSet<ProductVendor> ProductVendor { get; set; }

    public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }

    public virtual DbSet<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }

    public virtual DbSet<SalesOrderDetail> SalesOrderDetail { get; set; }

    public virtual DbSet<SalesOrderHeader> SalesOrderHeader { get; set; }

    public virtual DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason { get; set; }

    public virtual DbSet<SalesPerson> SalesPerson { get; set; }

    public virtual DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistory { get; set; }

    public virtual DbSet<SalesReason> SalesReason { get; set; }

    public virtual DbSet<SalesTaxRate> SalesTaxRate { get; set; }

    public virtual DbSet<SalesTerritory> SalesTerritory { get; set; }

    public virtual DbSet<SalesTerritoryHistory> SalesTerritoryHistory { get; set; }

    public virtual DbSet<ScrapReason> ScrapReason { get; set; }

    public virtual DbSet<Shift> Shift { get; set; }

    public virtual DbSet<ShipMethod> ShipMethod { get; set; }

    public virtual DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }

    public virtual DbSet<SpecialOffer> SpecialOffer { get; set; }

    public virtual DbSet<SpecialOfferProduct> SpecialOfferProduct { get; set; }

    public virtual DbSet<StateProvince> StateProvince { get; set; }

    public virtual DbSet<Store> Store { get; set; }

    public virtual DbSet<TransactionHistory> TransactionHistory { get; set; }

    public virtual DbSet<TransactionHistoryArchive> TransactionHistoryArchive { get; set; }

    public virtual DbSet<UnitMeasure> UnitMeasure { get; set; }

    public virtual DbSet<VAdditionalContactInfo> VAdditionalContactInfo { get; set; }

    public virtual DbSet<VEmployee> VEmployee { get; set; }

    public virtual DbSet<VEmployeeDepartment> VEmployeeDepartment { get; set; }

    public virtual DbSet<VEmployeeDepartmentHistory> VEmployeeDepartmentHistory { get; set; }

    public virtual DbSet<VIndividualCustomer> VIndividualCustomer { get; set; }

    public virtual DbSet<VJobCandidate> VJobCandidate { get; set; }

    public virtual DbSet<VJobCandidateEducation> VJobCandidateEducation { get; set; }

    public virtual DbSet<VJobCandidateEmployment> VJobCandidateEmployment { get; set; }

    public virtual DbSet<VPersonDemographics> VPersonDemographics { get; set; }

    public virtual DbSet<VProductAndDescription> VProductAndDescription { get; set; }

    public virtual DbSet<VProductModelCatalogDescription> VProductModelCatalogDescription { get; set; }

    public virtual DbSet<VProductModelInstructions> VProductModelInstructions { get; set; }

    public virtual DbSet<VSalesPerson> VSalesPerson { get; set; }

    public virtual DbSet<VSalesPersonSalesByFiscalYears> VSalesPersonSalesByFiscalYears { get; set; }

    public virtual DbSet<VStateProvinceCountryRegion> VStateProvinceCountryRegion { get; set; }

    public virtual DbSet<VStoreWithAddresses> VStoreWithAddresses { get; set; }

    public virtual DbSet<VStoreWithContacts> VStoreWithContacts { get; set; }

    public virtual DbSet<VStoreWithDemographics> VStoreWithDemographics { get; set; }

    public virtual DbSet<VVendorWithAddresses> VVendorWithAddresses { get; set; }

    public virtual DbSet<VVendorWithContacts> VVendorWithContacts { get; set; }

    public virtual DbSet<Vendor> Vendor { get; set; }

    public virtual DbSet<WorkOrder> WorkOrder { get; set; }

    public virtual DbSet<WorkOrderRouting> WorkOrderRouting { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new Configurations.AddressConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.AddressTypeConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.AwbuildVersionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.BillOfMaterialsConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.BusinessEntityConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.BusinessEntityAddressConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.BusinessEntityContactConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ContactTypeConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CountryRegionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CountryRegionCurrencyConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CreditCardConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CultureConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CurrencyConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CurrencyRateConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.DatabaseLogConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.DepartmentConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmailAddressConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmployeeConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmployeeDepartmentHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmployeePayHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ErrorLogConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.IllustrationConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.JobCandidateConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.LocationConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.PasswordConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.PersonConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.PersonCreditCardConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.PersonPhoneConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.PhoneNumberTypeConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProductConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProductCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProductCostHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProductDescriptionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProductInventoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProductListPriceHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProductModelConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProductModelIllustrationConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProductModelProductDescriptionCultureConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProductPhotoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProductProductPhotoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProductReviewConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProductSubcategoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ProductVendorConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.PurchaseOrderDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.PurchaseOrderHeaderConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SalesOrderDetailConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SalesOrderHeaderConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SalesOrderHeaderSalesReasonConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SalesPersonConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SalesPersonQuotaHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SalesReasonConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SalesTaxRateConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SalesTerritoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SalesTerritoryHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ScrapReasonConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ShiftConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ShipMethodConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.ShoppingCartItemConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SpecialOfferConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SpecialOfferProductConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StateProvinceConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StoreConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TransactionHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.TransactionHistoryArchiveConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.UnitMeasureConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VAdditionalContactInfoConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VEmployeeConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VEmployeeDepartmentConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VEmployeeDepartmentHistoryConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VIndividualCustomerConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VJobCandidateConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VJobCandidateEducationConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VJobCandidateEmploymentConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VPersonDemographicsConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VProductAndDescriptionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VProductModelCatalogDescriptionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VProductModelInstructionsConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VSalesPersonConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VSalesPersonSalesByFiscalYearsConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VStateProvinceCountryRegionConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VStoreWithAddressesConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VStoreWithContactsConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VStoreWithDemographicsConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VVendorWithAddressesConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VVendorWithContactsConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.VendorConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.WorkOrderConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.WorkOrderRoutingConfiguration());

        //OnModelCreatingGeneratedProcedures(modelBuilder);
        //OnModelCreatingGeneratedFunctions(modelBuilder);
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
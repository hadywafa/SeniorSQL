﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using EF_AdvectureWorks.Models.dboSchema;
using EF_AdvectureWorks.Models.HumanResourcesSchema;
using EF_AdvectureWorks.Models.PersonSchema;
using EF_AdvectureWorks.Models.ProductionSchema;
using EF_AdvectureWorks.Models.PurchasingSchema;
using EF_AdvectureWorks.Models.SalesSchema;


namespace EF_AdvectureWorks.Models.PersonSchema;

/// <summary>
/// Source of the ID that connects vendors, customers, and employees with address and contact information.
/// </summary>
public partial class BusinessEntity
{
    /// <summary>
    /// Primary key for all customers, vendors, and employees.
    /// </summary>
    public int BusinessEntityId { get; set; }

    /// <summary>
    /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
    /// </summary>
    public Guid Rowguid { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<BusinessEntityAddress> BusinessEntityAddress { get; set; } = new List<BusinessEntityAddress>();

    public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; } = new List<BusinessEntityContact>();

    public virtual Person? Person { get; set; }

    public virtual Store? Store { get; set; }

    public virtual Vendor? Vendor { get; set; }
}
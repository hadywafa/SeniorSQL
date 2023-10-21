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
/// Lookup table containing the ISO standard codes for countries and regions.
/// </summary>
public partial class CountryRegion
{
    /// <summary>
    /// ISO standard code for countries and regions.
    /// </summary>
    public string CountryRegionCode { get; set; } = null!;

    /// <summary>
    /// Country or region name.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<CountryRegionCurrency> CountryRegionCurrency { get; set; } = new List<CountryRegionCurrency>();

    public virtual ICollection<SalesTerritory> SalesTerritory { get; set; } = new List<SalesTerritory>();

    public virtual ICollection<StateProvince> StateProvince { get; set; } = new List<StateProvince>();
}
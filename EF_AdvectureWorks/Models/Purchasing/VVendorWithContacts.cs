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


namespace EF_AdvectureWorks.Models.PurchasingSchema;

public partial class VVendorWithContacts
{
    public int BusinessEntityId { get; set; }

    public string Name { get; set; } = null!;

    public string ContactType { get; set; } = null!;

    public string? Title { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string? Suffix { get; set; }

    public string? PhoneNumber { get; set; }

    public string? PhoneNumberType { get; set; }

    public string? EmailAddress { get; set; }

    public int EmailPromotion { get; set; }
}
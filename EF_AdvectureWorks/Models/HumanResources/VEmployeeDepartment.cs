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


namespace EF_AdvectureWorks.Models.HumanResourcesSchema;

public partial class VEmployeeDepartment
{
    public int BusinessEntityId { get; set; }

    public string? Title { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string? Suffix { get; set; }

    public string JobTitle { get; set; } = null!;

    public string Department { get; set; } = null!;

    public string GroupName { get; set; } = null!;

    public DateTime StartDate { get; set; }
}
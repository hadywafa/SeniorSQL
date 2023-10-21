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


namespace EF_AdvectureWorks.Models.SalesSchema;

/// <summary>
/// Contains online customer orders until the order is submitted or cancelled.
/// </summary>
public partial class ShoppingCartItem
{
    /// <summary>
    /// Primary key for ShoppingCartItem records.
    /// </summary>
    public int ShoppingCartItemId { get; set; }

    /// <summary>
    /// Shopping cart identification number.
    /// </summary>
    public string ShoppingCartId { get; set; } = null!;

    /// <summary>
    /// Product quantity ordered.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Product ordered. Foreign key to Product.ProductID.
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Date the time the record was created.
    /// </summary>
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    public DateTime ModifiedDate { get; set; }

    public virtual Product Product { get; set; } = null!;
}
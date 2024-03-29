﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable


using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AspNetOdata.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Barcode { get; set; }

    public string ImageDataUrl { get; set; }

    public string Description { get; set; }

    public decimal Rate { get; set; }

    public int BrandId { get; set; }

    [JsonIgnore]
    public string CreatedBy { get; set; } = Guid.NewGuid().ToString();
    [JsonIgnore]
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    [JsonIgnore]
    public string LastModifiedBy { get; set; }  = Guid.NewGuid().ToString();
    [JsonIgnore]
    public DateTime? LastModifiedOn { get; set; } = DateTime.UtcNow;

    public virtual Brand Brand { get; set; }
}
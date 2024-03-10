

using System.Text.Json.Serialization;

public class Product
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Barcode { get; set; }

    public string ImageDataUrl { get; set; }

    public string Description { get; set; }

    public decimal Rate { get; set; }

    public int BrandId { get; set; }

    [JsonIgnore]
    public string CreatedBy { get; set; }
    [JsonIgnore]
    public DateTime CreatedOn { get; set; }
    [JsonIgnore]
    public string LastModifiedBy { get; set; }
    [JsonIgnore]
    public DateTime? LastModifiedOn { get; set; }

    public virtual Brand Brand { get; set; }
}


public class Brand
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Tax { get; set; }

    [JsonIgnore]
    public string CreatedBy { get; set; }
    [JsonIgnore]
    public DateTime CreatedOn { get; set; }
    [JsonIgnore]
    public string LastModifiedBy { get; set; }
    [JsonIgnore]
    public DateTime? LastModifiedOn { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
using Simple.OData.Client;

try
{
    var client = new ODataClient("https://localhost:7003/odata/");

    var products = await client
            .For<Product>()
            .Expand(x=>x.Brand)
            .FindEntriesAsync();

    foreach (var product in products)
    {
        Console.WriteLine(product.Brand.Name);
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();
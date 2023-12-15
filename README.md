# ASP.NET Core OData Project

Brief description of your ASP.NET Core OData project.

## Overview

Explain the purpose and functionality of your ASP.NET Core OData service. Provide a brief introduction to OData and its benefits in your project. Mention any key features that make your OData service unique.

## Prerequisites

Specify any prerequisites that users need to have installed or set up before using your project. Include things like:

- [.NET 7 SDK](https://dotnet.microsoft.com/download)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- Other dependencies...

## Getting Started

Provide instructions on how to get started with your ASP.NET Core OData service. Include steps such as:

1. Clone the repository: `git clone https://github.com/yourusername/yourproject.git`
2. Navigate to the project directory: `cd yourproject`
3. Build the solution: `dotnet build`
4. Run the ASP.NET Core OData service: `dotnet run --project YourODataServiceProject`

## OData Endpoints

Includes examples of how users can interact with these endpoints, including filtering, sorting, and querying.

## Configuration

## Console Client

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

### Example:

http
https://localhost:7003/api/Product?$expand=Brand

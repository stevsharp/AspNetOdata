using Simple.OData.Client;

namespace BlazorAppOdataClient.Pages
{
    public partial class Home
    {

        IEnumerable<Product> products;
        private async Task GetData()
        {
            try
            {
                var client = new ODataClient("https://localhost:7003/odata/");

                products = await client
                        .For<Product>()
                        .Expand(x => x.Brand)
                        .FindEntriesAsync();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

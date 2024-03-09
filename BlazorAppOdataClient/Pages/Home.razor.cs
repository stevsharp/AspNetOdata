using Simple.OData.Client;

namespace BlazorAppOdataClient.Pages
{
    public partial class Home
    {
        ODataClient client = new ODataClient("https://localhost:7003/odata/");
        IEnumerable<Product> products;
        private async Task GetData()
        {
            try
            {
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

        private async Task GetDataWithId()
        {
            try
            {
                var product = await client
                        .For<Product>()
                        .Key(1)
                        .Expand(x => x.Brand)
                        .FindEntryAsync();

                products = new List<Product>()
                {
                    product
                };

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

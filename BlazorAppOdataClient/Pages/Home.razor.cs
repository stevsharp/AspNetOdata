using Simple.OData.Client;

namespace BlazorAppOdataClient.Pages
{
    public partial class Home
    {
        protected ODataClient client = new ODataClient("https://localhost:7003/odata/");
        protected IEnumerable<Product> products;

        protected string errorMessage = string.Empty;

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
                errorMessage = string.Empty;

                errorMessage = ex.Message;

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


                await this.GetData();
                
            }
            catch (Exception ex)
            {
                errorMessage = string.Empty;

                errorMessage = ex.Message;

                Console.WriteLine(ex.Message);
            }

        }

        private async Task CreateProduct()
        {
            try
            {
                var product = await client
                    .For<Product>()
                    .Set(new 
                    {
                        Barcode = "Test",
                        Description = "Test",
                        ImageDataUrl = "Test",
                        Name = "Test",  
                        Rate = 1,
                        BrandId = 1
                    })
                    .InsertEntryAsync();

                await this.GetData();

            }
            catch (Exception ex)
            {
                errorMessage = string.Empty;

                errorMessage = ex.Message;

                Console.WriteLine(ex.Message);
            }

        }
    }
}

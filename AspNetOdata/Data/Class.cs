using AspNetOdata.Models;

using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace AspNetOdata.Data
{
    internal static class EdmModel
    {
        public static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new();

            builder.EntitySet<Product>("Product");


            return builder.GetEdmModel();
        }
    }
}

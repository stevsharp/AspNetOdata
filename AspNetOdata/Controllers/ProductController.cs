using AspNetOdata.Models;

using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;

using System.Linq.Expressions;

namespace AspNetOdata.Controllers
{

    public class ProductController : ODataController
    {
        protected readonly EClinicContext _eClinicContext;

        public ProductController(EClinicContext eClinicContext)
        {
            _eClinicContext = eClinicContext;
        }


        [EnableQuery]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_eClinicContext.Products.AsQueryable());
        }

        [ODataRoute("({key})")]
        [EnableQuery]
        public virtual SingleResult<Product> Get([FromODataUri] int key)
        { 
            return SingleResult.Create(_eClinicContext.Set<Product>().Where(x=>x.Id == key).AsQueryable());
        }

    }
}

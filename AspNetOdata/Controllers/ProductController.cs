using AspNetOdata.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;

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

    }
}

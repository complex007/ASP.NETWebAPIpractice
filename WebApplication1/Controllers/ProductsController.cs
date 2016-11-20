using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace WebApplication1.Controllers
{
    public class ProductsController : ApiController
    {
        Team6PropertyDBEntities propertymodel = new Team6PropertyDBEntities();
        public List<Property> GetAllProducts()
        {
            return propertymodel.Properties.ToList<Property>();
        }

        public IHttpActionResult GetProperty(int id)
        {
            var property = propertymodel.Properties.FirstOrDefault((p) => p.PropertyID == id);
            if (property == null)
            {
                return NotFound();
            }
            return Ok(property);
        }
    }
}

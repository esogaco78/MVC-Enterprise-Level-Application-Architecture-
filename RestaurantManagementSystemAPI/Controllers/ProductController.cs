using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessEntities;


using AttributeRouting;
using AttributeRouting.Web.Http;
using BusinessServices.Interfaces;

namespace RestaurantManagementAPI.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductServices productServices;
        public ProductController(IProductServices _productServices)
        {
            productServices = _productServices;
        }

        // GET /products

        [HttpGet]
        [Route("products")]
        public HttpResponseMessage Get()
        {
            try
            {
                var products = productServices.GetAllProducts();
                if (products != null)
                {
                    var productEntities = products as List<ProductEntity> ?? products.ToList();
                    if (productEntities.Any())
                        return Request.CreateResponse(HttpStatusCode.OK, productEntities);
                }
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Products not found");
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return Request.CreateResponse(HttpStatusCode.BadRequest, message);
            }

        }
    }
}

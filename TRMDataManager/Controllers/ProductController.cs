﻿using System.Collections.Generic;
using System.Web.Http;
using TRMDataManager.Library.DataAccess;
using TRMDataManager.Library.Models;

namespace TRMDataManager.Controllers
{
    [Authorize]
    public class ProductController : ApiController
    {
        [HttpGet]
        public List<ProductModel> Get()
        {
            ProductData data = new ProductData();

            return data.GetProducts();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiTest.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[] 
        { 
            new Product{Id=1,Name="Tomato Soup",Category="Groceries",Price=1},
            new Product{Id=2,Name="Yo-yo",Category="Toys",Price=3.75M},
            new Product{Id=3,Name="Hammer",Category="Hardware",Price=16.99M},
        };

        // GET api/products
        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET api/products/5
        public IHttpActionResult Get(int id)
        {
            var prodct = products.FirstOrDefault(p=>p.Id==id);
            if (prodct == null)
            {
                return NotFound();
            }
            return Ok(prodct);
        }

    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}

﻿using IndicShopApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IndicShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public IEnumerable<Product> Products = new List<Product>();

        public ProductsController()
        {
            Products = new Product[]
            {
                new Product{
                    Id = 1,
                    Title = "Bag - Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops",
                    Price = 109.95,
                    Description = "Your perfect pack for everyday use and walks in the forest. Stash your laptop (up to 15 inches) in the padded sleeve, your everyday",
                    Category = "men's clothing",
                    Image = "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg",
                    Rating = new Rating
                    {
                        Rate = 3.9,
                        Count = 120
                    }
                },
                new Product{
                    Id = 2,
                    Title = "B&W T-Shirt-Mens Casual Premium Slim Fit T-Shirts ",
                    Price = 22.35,
                    Description = "Slim-fitting style, contrast raglan long sleeve, three-button henley placket, light weight & soft fabric for breathable and comfortable wearing. And Solid stitched shirts with round neck made for durability and a great fit for casual fashion wear and diehard baseball fans. The Henley style round neckline includes a three-button placket.",
                    Category = "men's clothing",
                    Image = "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg ",
                    Rating = new Rating
                    {
                        Rate = 4.1,
                        Count = 259
                    }
                },
                new Product{
                    Id = 3,
                    Title = "Jacket - Mens Cotton Jacket",
                    Price = 55.99,
                    Description = "great outerwear jackets for Spring/Autumn/Winter, suitable for many occasions, such as working, hiking, camping, mountain/rock climbing, cycling, traveling or other outdoors. Good gift choice for you or your family member. A warm hearted love to Father, husband or son in this thanksgiving or Christmas Day.",
                    Category = "men's clothing",
                    Image = "https://fakestoreapi.com/img/71li-ujtlUL._AC_UX679_.jpg",
                    Rating = new Rating
                    {
                        Rate = 4.7,
                        Count = 500
                    }
                },
                new Product{
                    Id = 4,
                    Title = "Blue-T-Shirt- Mens Casual Slim Fit",
                    Price = 55.99,
                    Description = "The color could be slightly different between on the screen and in practice. / Please note that body builds vary by person, therefore, detailed size information should be reviewed below on the product description.",
                    Category = "men's clothing",
                    Image = "https://fakestoreapi.com/img/71YXzeOuslL._AC_UY879_.jpg",
                    Rating = new Rating
                    {
                        Rate = 2.1,
                        Count = 430
                    }
                },
            };
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAll()
        {
            var products = Products;
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            var product = Products.FirstOrDefault(x => x.Id == id);

            return Ok(product);
        }
    }
}

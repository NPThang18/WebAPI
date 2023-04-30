using DotNet_WebAPI_Core.DAO;
using DotNet_WebAPI_Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_WebAPI_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Data.listProduct);
        }
        [HttpGet("id")]
        public IActionResult GetById(string id)
        {
            try
            {
                var product = Data.listProduct.Where(p => p.Key == Guid.Parse(id)).SingleOrDefault();
                if (product == null) return NotFound();
                return Ok(product);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult AddProduct(Product model)
        {
            model.Key = Guid.NewGuid();
            Data.listProduct.Add(model);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Edit(Product model, Guid id)
        {
            try
            {
                var product = Data.listProduct.SingleOrDefault(x => x.Key == id);
                if (product == null)
                {
                    return NotFound();
                }

                product.Name = model.Name;
                product.Price = model.Price;
                return Ok(product);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            var product = Data.listProduct.Where(p => p.Key == id).SingleOrDefault();
            if(product == null)
            {
                return NotFound();
            }

            Data.listProduct.Remove(product);
            return Ok();
        }
    }
}

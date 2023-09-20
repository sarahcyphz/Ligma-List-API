using Microsoft.AspNetCore.Mvc;
using ligma_list.Domain.catalog;
using ligma_list.Data;

namespace ligma_list.Api.Controllers
{
    [ApiController]
    [Route("/catalog")]
    public class CatalogController : ControllerBase
    {
        private readonly SpiceContext _db;

        public CatalogController(SpiceContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok(_db.Items);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetItem(int id)
        {
            var item = new Item("Tajin");
            item.Id = id;

            return Ok(item);
        }

        [HttpPost]
        public IActionResult Post(Item item)
        {
            return Created("/catalog/42", item);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }


    }
}
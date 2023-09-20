using Microsoft.AspNetCore.Mvc;
using ligma_list.Domain.catalog;

namespace ligma_list.Api.Controllers
{
    [ApiController]
    [Route("/catalog")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            var items = new List<Item>()
            {
                new Item("Paprika"),
                new Item("Garlic Salt"),
            };

            return Ok(items);
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
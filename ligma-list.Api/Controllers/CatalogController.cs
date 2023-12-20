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
            var sortedItems = _db.Items.OrderByDescending(item => item.IsNeeded).ToList();

            return Ok(sortedItems);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetItem(int id)
        {
            var item = _db.Items.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(Item item)
        {
            _db.Items.Add(item);
            _db.SaveChanges();
            return CreatedAtAction($"/catalog/{item.Id}", item);
        }

        [HttpPut("{id:int}")]
        public IActionResult PutItem(int id, Item itemUpdate)
        {
            var existingItem = _db.Items.Find(id);

            if (existingItem == null)
            {
                return NotFound();
            }
            existingItem.IsNeeded = itemUpdate.IsNeeded;
            _db.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteItem(int id)
        {
            var item = _db.Items.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            _db.Items.Remove(item);
            _db.SaveChanges();

            return Ok();
        }


    }
}
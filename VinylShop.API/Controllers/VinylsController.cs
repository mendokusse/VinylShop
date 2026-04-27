using Microsoft.AspNetCore.Mvc;
using VinylShop.API.Models;


namespace VinylShop.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VinylsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Vinyl>> GetAll()
        {
            var vinyls = new List<Vinyl> {
                new Vinyl
                {
                    Id = 1,
                    Title = "Good kid, mad city",
                    Artist = "Kendrick Lamar",
                    Year = 2012,
                    Price = 67.52m
                }
            };

            return Ok(vinyls);
        }

    }
}


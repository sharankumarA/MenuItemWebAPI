using MenuItemWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MenuItemWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuItemController : ControllerBase

    {
        public readonly List<MenuItem> menuItems = new List<MenuItem>()
                        {
                            new MenuItem{
                                Id = 1,
                                Name = "Dosa",
                                FreeDelivery = true,
                                Price = 70,
                                DateOfLaunch = System.DateTime.Parse("2000/01/02"),
                                Active = true,
                            },
                            new MenuItem{
                                Id = 2,
                                Name = "Briyani",
                                FreeDelivery = true,
                                Price = 120,
                                DateOfLaunch = System.DateTime.Parse("2010/01/02"),
                                Active = true,
                            },
                            new MenuItem{
                                Id = 3,
                                Name = "Falooda",
                                FreeDelivery = false,
                                Price = 100,
                                DateOfLaunch = System.DateTime.Parse("2015/02/10"),
                                Active = true,
                            }
                        };




        [HttpGet]
        public IActionResult GetMenuItem()
        {
            return Ok(menuItems);
        }

        [HttpGet("{id}")]
        public IActionResult GetMenuItemById(int id)
        {
            foreach (var item in menuItems)
            {
                if (item.Id == id)
                    return Ok(item);
            }
            return BadRequest();
        }



    }
}

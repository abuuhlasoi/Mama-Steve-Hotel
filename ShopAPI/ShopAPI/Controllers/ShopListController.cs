using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopListController : ControllerBase
    {
        [HttpPost]
        public object AddItem(ShoppingListModel obj)
        {
            return new Response
            {
                Status = "Success",
                Message = "Item added successfully."
            };
                
        }
    }
}

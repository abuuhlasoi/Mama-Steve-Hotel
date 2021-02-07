using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevOp_MamaSteveShop.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class GetItemsListController : ControllerBase
    {
        [HttpGet]
        [Route("DisplayShoppingList")]
        [EnableCors("AllowOrigin")]
        public IActionResult DisplayShoppingList()
        {
            return Ok();
        }
    }
}

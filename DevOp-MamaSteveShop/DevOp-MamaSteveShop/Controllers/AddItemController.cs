using DevOp_MamaSteveShop.Models;
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
    public class AddItemController : ControllerBase
    {
        [Route("AddItem")]
        [HttpPost]
        public object AddItem(ShoppingListModel obj)
        {
            //add into data.json
            return new Response
            {
                Status = "Success",
                Message = "Data Successfully"

            };
        }
    }
}

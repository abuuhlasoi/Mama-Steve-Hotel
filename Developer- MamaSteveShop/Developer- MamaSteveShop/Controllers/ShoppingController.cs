using Developer__MamaSteveShop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Developer__MamaSteveShop.Controllers
{
    public class ShoppingController : ApiController
    {
        [HttpPost]
        public Response Post([FromBody] ShoppingList obj)
        {
            Response response = new Response();
            try
            {
                string path = @"C:\Users\Kelvin\OneDrive\Projects\data.json";
                //post mama steve data to data.json file

                //open file stream
                using (StreamWriter file = File.CreateText(path))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    //serialize object directly into file stream
                    serializer.Serialize(file, obj);
                }

                response.responseCode = true;
                response.responseDescription = obj.Type + ":" + obj.items[0].Item + "was added successfully.";
                return response;
            }

            catch(Exception ex) 
            {
                response.responseCode = false;
                response.responseDescription = ex.Message;
                return response;
            }
        }
    }
}

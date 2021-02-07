using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevOp_MamaSteveShop.Models
{
    public class ShoppingListModel
    {
        public string Type { get; set; }
        public List<Items> items { get; set; }
    }
    public partial class Items
    {
        public string Item { get; set; }
        public decimal Price { get; set; } 
    }
    public class Response
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }
}

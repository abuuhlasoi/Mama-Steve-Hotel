using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Developer__MamaSteveShop.Models
{
    public class ShoppingList
    {
        public string Type { get; set; }
        public List<Items> items { get; set; }
    }  
    public partial class Items 
    {
        public string Item { get; set; }
        public decimal Price { get; set; } 
    }
}
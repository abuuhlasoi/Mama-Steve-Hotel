using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Developer__MamaSteveShop.Models
{
    public class ShoppingListModel
    {
        public string Fruits { get; set; }
        public string Vegetables { get; set; }
        public string Meat { get; set; }
        public Items items { get; set; }
    } 
    public partial class Items 
    {
        public string Item { get; set; }
        public decimal Price { get; set; } 
    }
}
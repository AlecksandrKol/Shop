using System.Collections.Generic;

namespace Shop.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryName { get; set; }

        public int desc { get; set; }

        public List<Item> items { get; set; } 
    }
}

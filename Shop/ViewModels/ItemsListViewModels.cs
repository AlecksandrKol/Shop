using Microsoft.AspNetCore.Cors.Infrastructure;
using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.ViewModels
{
    public class ItemsListViewModels
    {
        public IEnumerable<Item> AllItems { get; set; }

        public string currCategory { get; set; }
    }
}

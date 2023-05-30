using System.Collections;
using System.Collections.Generic;
using Shop.Data.Models;

namespace Shop.Data.Interfaces
{
    public interface IItemsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}

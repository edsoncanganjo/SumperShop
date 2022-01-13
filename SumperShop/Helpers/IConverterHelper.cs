using SumperShop.Data.Entities;
using SumperShop.Models;
using System;

namespace SumperShop.Helpers
{
    public interface IConverterHelper
    {
        Product ToProduct(ProductViewModel model, Guid imageId, bool isNew);
        ProductViewModel ToProductViewModel(Product product);
    }
}

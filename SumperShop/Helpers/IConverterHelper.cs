using SumperShop.Data.Entities;
using SumperShop.Models;

namespace SumperShop.Helpers
{
    public interface IConverterHelper
    {
        Product ToProduct(ProductViewModel model, string path, bool isNew);
        ProductViewModel ToProductViewModel(Product product);
    }
}

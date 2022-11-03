using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        // Not in use
        // we do signutre for those two methods
         Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
         Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
         Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    }
}
using ECommerce.Api.Models.Common;

namespace ECommerce.Api.Services.Products;

public interface IProductsService
{
    IEnumerable<IProduct> GetAll();

    IProduct? Add(IProduct product);

    IProduct? GetById(Guid id);

    IProduct? Update(IProduct product);

    bool Delete(Guid id);
}
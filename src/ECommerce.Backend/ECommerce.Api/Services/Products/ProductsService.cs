using ECommerce.Api.Data.DataContexts;
using ECommerce.Api.Models.Common;

namespace ECommerce.Api.Services.Products;

public class ProductsService : IProductsService
{
    private readonly AppDataContext _appDataContext;

    // public List<IProduct> Products
    // {
    //     get
    //     {
    //         var list = new List<IProduct>();
    //         list.AddRange(_appDataContext.Laptops.OfType<IProduct>());
    //         list.AddRange(_appDataContext.Phones.OfType<IProduct>());
    //
    //         // _appDataContext.Laptops.Cast<IProduct>().Concat(_appDataContext.Phones);
    //
    //         // list.AddRange();
    //
    //         return list;
    //     }
    // }

    public ProductsService(AppDataContext appDataContext)
    {
        _appDataContext = appDataContext;
    }

    public IEnumerable<IProduct> GetAll()
    {
        return _appDataContext.Phones;
        // return Products.ToList();
    }

    public IProduct? Add(IProduct product)
    {
        throw new NotImplementedException();
    }

    public IProduct? GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public IProduct? Update(IProduct product)
    {
        throw new NotImplementedException();
    }

    public bool Delete(IProduct product)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}
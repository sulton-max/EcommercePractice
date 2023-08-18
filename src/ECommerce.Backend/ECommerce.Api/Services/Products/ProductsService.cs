using ECommerce.Api.Data.DataContexts;
using ECommerce.Api.Models.Common;
using ECommerce.Api.Models.Entities;

namespace ECommerce.Api.Services.Products;

public class ProductsService : IProductsService
{
    private readonly AppDataContext _appDataContext;

    public ProductsService(AppDataContext appDataContext)
    {
        _appDataContext = appDataContext;
    }

    public IEnumerable<IProduct> GetAll()
    {
        return _appDataContext.Phones.Cast<IProduct>().Concat(_appDataContext.Laptops);
    }

    public IProduct? Add(IProduct product)
    {
        if (product is Phone phone)
        {
            _appDataContext.Phones.Add(phone);
            return phone;
        }

        if (product is Laptop laptop)
        {
            _appDataContext.Laptops.Add(laptop);
            return laptop;
        }

        return null;
    }

    public IProduct? GetById(Guid id)
    {
        return GetAll().FirstOrDefault(item => item.Id == id);
    }

    public IProduct? Update(IProduct product)
    {
        if (product is Phone phone)
        {
            var foundPhone = _appDataContext.Phones.FirstOrDefault(item => item.Id == phone.Id);
            if (foundPhone is null)
                return null;

            foundPhone.Name = phone.Name;
            foundPhone.Price = phone.Price;
            foundPhone.ImageUrl = phone.ImageUrl;

            return foundPhone;
        }

        if (product is Laptop laptop)
        {
            var foundPhone = _appDataContext.Laptops.FirstOrDefault(item => item.Id == laptop.Id);
            if (foundPhone is null)
                return null;

            foundPhone.Name = laptop.Name;
            foundPhone.Price = laptop.Price;
            foundPhone.ImageUrl = laptop.ImageUrl;

            return foundPhone;
        }

        return null;
    }

    public bool Delete(Guid id)
    {
        var foundProduct = GetById(id);

        if (foundProduct is null)
            return false;

        if (foundProduct is Phone phone)
            return _appDataContext.Phones.RemoveAll(item => item.Id == phone.Id) > 0;

        if (foundProduct is Laptop laptop)
            return _appDataContext.Phones.RemoveAll(item => item.Id == laptop.Id) > 0;

        return false;
    }
}
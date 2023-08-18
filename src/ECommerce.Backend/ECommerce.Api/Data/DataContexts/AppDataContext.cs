using ECommerce.Api.Models.Entities;

namespace ECommerce.Api.Data.DataContexts;

public class AppDataContext
{
    // public List<Phone> Phones { get; init; } = new();
    public List<Phone> Phones { get; init; } = new()
    {
        new Phone("IPhone 12", 1200, ""),
        new Phone("IPhone 12", 1200, "")
    };

    public List<Laptop> Laptops { get; init; } = new();
}
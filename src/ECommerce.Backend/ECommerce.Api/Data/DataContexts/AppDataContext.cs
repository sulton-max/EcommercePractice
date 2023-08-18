using ECommerce.Api.Models.Entities;

namespace ECommerce.Api.Data.DataContexts;

public class AppDataContext
{
    // public List<Phone> Phones { get; init; } = new();
    public List<Phone> Phones { get; init; } = new()
    {
        new Phone
        {
            Name = "IPhone 14",
            Price = 1400
        },
        new Phone
        {
            Name = "IPhone 14",
            Price = 1400
        }
    };

    public List<Laptop> Laptops { get; init; } = new();
}
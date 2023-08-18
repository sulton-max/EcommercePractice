using ECommerce.Api.Models.Common;

namespace ECommerce.Api.Models.Entities;

public class Laptop : IProduct
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public string ImageUrl { get; set; }

    public Laptop()
    {
    }

    public Laptop(string name, int price, string imageUrl)
    {
        Id = Guid.NewGuid();
        Name = name;
        Price = price;
        ImageUrl = imageUrl;
    }
}
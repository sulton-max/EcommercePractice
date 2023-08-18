using ECommerce.Api.Models.Common;

namespace ECommerce.Api.Models.Entities;

public class Phone : IProduct
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public string ImageUrl { get; set; }

    public Phone()
    {
    }

    public Phone(string name, int price, string imageUrl)
    {
        Id = Guid.NewGuid();
        Name = name;
        Price = price;
        ImageUrl = imageUrl;
    }
}
namespace ECommerce.Api.Models.Common;

public interface IProduct : IEntity
{
    string Name { get; set; }
    int Price { get; set; }
    string ImageUrl { get; set; }
}
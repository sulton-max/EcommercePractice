using ECommerce.Api.Models.Common;

namespace ECommerce.Api.Models.Entities;

public class Phone : IProduct
{
    public string Name { get; set; }
    public int Price { get; set; }
}
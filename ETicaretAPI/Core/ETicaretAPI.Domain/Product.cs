using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Domain;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public long Price { get; set; }
    
    public ICollection<Order> Orders { get; set; }
}
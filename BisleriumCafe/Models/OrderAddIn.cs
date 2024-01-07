using BisleriumCafe.Models.Base;

namespace BisleriumCafe.Models;

public class OrderAddIn : BaseEntity
{
    public Guid OrderId { get; set; } = Guid.Empty;

    public Guid AddInId { get; set; } = Guid.Empty;

    public int AddInQuantity { get; set; }
}
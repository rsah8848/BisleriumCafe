using BisleriumCafe.Models.Base;
using BisleriumCafe.Models.Enums;

namespace BisleriumCafe.Models;

public class Order : BaseEntity
{
    public Guid CustomerId { get; set; } = Guid.Empty;

    public Guid CoffeeId { get; set; } = Guid.Empty;

    public int CoffeeQuantity { get; set; }

    public decimal TotalPrice { get; set; }

    public PaymentMode PaymentMode { get; set; }
}
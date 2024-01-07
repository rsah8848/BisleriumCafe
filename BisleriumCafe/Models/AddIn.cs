using BisleriumCafe.Models.Base;
using BisleriumCafe.Models.Enums;

namespace BisleriumCafe.Models;

public class AddIn : BaseEntity
{
    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public Unit Unit { get; set; } = 0;
}
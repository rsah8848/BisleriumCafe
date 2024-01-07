using BisleriumCafe.Models.DTOs;

namespace BisleriumCafe.PDF;

public class PDF
{
    public string Frequency { get; set; }

    public string Title { get; set; }

    public decimal TotalRevenue { get; set; }

    public string FileName { get; set; }

    public string UserName { get; set; }

    public string Role { get; set; }

    public IEnumerable<OrderRecords> CoffeeRecords { get; set; }

    public IEnumerable<OrderRecords> AddInRecords { get; set; }
}
namespace Apps.FlowFit.Models.Dtos;

public class ClientQuoteSubItemDTO 
{
    public string Id { get; set; }
    public string ClientQuoteItemId { get; set; }
    public string ClientServiceId { get; set; }
    public int DisplayOrder { get; set; }
    public string? Description { get; set; }
    public decimal? Quantity { get; set; }
    public string UnitId { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal Total { get; set; }
}
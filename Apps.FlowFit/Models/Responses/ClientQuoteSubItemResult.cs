using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ClientQuoteSubItemResult 
{
    public string Id { get; set; }
    public string Guid { get; set; }
    public string ItemGuid { get; set; }
    public string ClientQuoteItemId { get; set; }
    public string ClientServiceId { get; set; }
    public string? ClientServiceDescription { get; set; }
    public int DisplayOrder { get; set; }
    public string? Description { get; set; }
    public decimal? Quantity { get; set; }
    public string UnitId { get; set; }
    public string? UnitDescription { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal Total { get; set; }
}
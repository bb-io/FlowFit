using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ClientInvoiceSubItemResult 
{
    public string Id { get; set; }
    public string Guid { get; set; }
    public string ItemGuid { get; set; }
    public string ClientInvoiceItemId { get; set; }
    public string ClientServiceId { get; set; }
    public string? ClientServiceDescription { get; set; }
    public string ProjectId { get; set; }
    public string? ProjectTitle { get; set; }
    public string? ProjectNumber { get; set; }
    public string? PurchaseOrder { get; set; }
    public string? CostCenter { get; set; }
    public string ClientQuoteSubItemId { get; set; }
    public string ClientQuoteId { get; set; }
    public string ClientQuoteDisplayId { get; set; }
    public int DisplayOrder { get; set; }
    public string? Description { get; set; }
    public decimal? Quantity { get; set; }
    public string UnitId { get; set; }
    public string? UnitDescription { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal Total { get; set; }
    public bool IsFlatRate { get; set; }
    public string? RequesterName { get; set; }
}
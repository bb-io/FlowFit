using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ProviderInvoiceItemResult 
{
    public string Id { get; set; }
    public string InvoiceId { get; set; }
    public int DisplayOrder { get; set; }
    public string ProjectId { get; set; }
    public string TaskId { get; set; }
    public string ServiceId { get; set; }
    public string? Service { get; set; }
    public string? Description { get; set; }
    public string UnitId { get; set; }
    public string? Unit { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal? Quantity { get; set; }
    public bool IsUrgent { get; set; }
    public decimal Total { get; set; }
    public string FinancialOrderItemId { get; set; }
}
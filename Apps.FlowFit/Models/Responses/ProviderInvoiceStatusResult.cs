using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ProviderInvoiceStatusResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public bool IsPertinentForSums { get; set; }
    public int? DisplayOrder { get; set; }
    public string? Color { get; set; }
}
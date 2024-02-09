using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class FinancialTaxDictionaryResult 
{
    public string Id { get; set; }
    public string FinancialTaxId { get; set; }
    public string? Culture { get; set; }
    public string? Description { get; set; }
}
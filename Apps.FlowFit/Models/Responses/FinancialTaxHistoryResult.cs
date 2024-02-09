using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class FinancialTaxHistoryResult 
{
    public string Id { get; set; }
    public string TaxId { get; set; }
    public decimal? TaxValue { get; set; }
    public DateTime? TaxDateStart { get; set; }
}
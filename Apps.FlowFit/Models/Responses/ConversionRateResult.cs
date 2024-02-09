using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ConversionRateResult 
{
    public string Id { get; set; }
    public string SourceCurrencyId { get; set; }
    public string? SourceCurrencyIsoCode { get; set; }
    public string? SourceCurrencySymbol { get; set; }
    public string TargetCurrencyId { get; set; }
    public string? TargetCurrencyIsoCode { get; set; }
    public string? TargetCurrencySymbol { get; set; }
    public decimal Rate { get; set; }
    public DateTime Date { get; set; }
}
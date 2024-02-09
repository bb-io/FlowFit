using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class CurrencyResult 
{
    public string Id { get; set; }
    public string? Name { get; set; }
    public string? LongName { get; set; }
    public string? IsoCode { get; set; }
    public string? Symbol { get; set; }
}
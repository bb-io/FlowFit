using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class LanguageSimpleResult 
{
    public string Id { get; set; }
    public string? Abrev { get; set; }
    public string? Description { get; set; }
    public string? IsoCode { get; set; }
}
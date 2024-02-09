using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class LanguageResult 
{
    public string Id { get; set; }
    public string? Abrev { get; set; }
    public string? Description { get; set; }
    public string? IsoCode { get; set; }
    public string? OriginalSourceAbrev { get; set; }
    public string? IsoCodeValue { get; set; }
    public bool IsCommunicationLanguage { get; set; }
}
using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class DelayReasonResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public IEnumerable<DelayReasonDictionaryDTO>? DelayReasonDictionary { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
    public string? DelayReasonDefaultLanguage { get; set; }
}
using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class TitleResult 
{
    public string Id { get; set; }
    public bool IsActive { get; set; }
    public string? Description { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
    public IEnumerable<TitleDictionaryDTO>? TitleDictionary { get; set; }
}
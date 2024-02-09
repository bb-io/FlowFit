using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class PositionResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; }
    public IEnumerable<PositionDictionaryDTO>? PositionDictionary { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
}
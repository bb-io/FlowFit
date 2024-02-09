using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ReadershipResult 
{
    public string Id { get; set; }
    public bool IsActive { get; set; }
    public string? Description { get; set; }
    public IEnumerable<ReadershipDictionaryDTO>? ReadershipDictionary { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
}
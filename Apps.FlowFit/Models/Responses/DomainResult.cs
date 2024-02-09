using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class DomainResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public string ModuleId { get; set; }
    public ModuleResult? Module { get; set; }
    public IEnumerable<DomainDictionaryDTO>? DomainDictionary { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
}
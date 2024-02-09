using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ModuleResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
    public string ProjectTemplateId { get; set; }
    public IEnumerable<ModuleDictionaryDTO>? ModuleDictionary { get; set; }
}
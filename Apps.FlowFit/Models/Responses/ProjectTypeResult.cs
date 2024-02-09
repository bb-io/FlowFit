using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ProjectTypeResult 
{
    public string Id { get; set; }
    public string ModuleId { get; set; }
    public ModuleResult? Module { get; set; }
    public string? Description { get; set; }
    public string? Abbreviation { get; set; }
    public IEnumerable<ProjectTypeDictionaryDTO>? ProjectTypeDictionary { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
}
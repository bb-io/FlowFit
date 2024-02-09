using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ProjectPriorityResult 
{
    public string Id { get; set; }
    public string? Color { get; set; }
    public int? SortOrder { get; set; }
    public bool IsActive { get; set; }
    public string? Description { get; set; }
    public IEnumerable<ProjectPriorityDictionaryDTO>? ProjectPriorityDictionary { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
}
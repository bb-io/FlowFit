namespace Apps.FlowFit.Models.Dtos;

public class ProjectTypeDTO 
{
    public string ModuleId { get; set; }
    public string? Description { get; set; }
    public string? Abbreviation { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}
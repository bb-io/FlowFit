namespace Apps.FlowFit.Models.Dtos;

public class ProjectPriorityDTO 
{
    public string? Color { get; set; }
    public int? SortOrder { get; set; }
    public bool IsActive { get; set; }
    public string Description { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}
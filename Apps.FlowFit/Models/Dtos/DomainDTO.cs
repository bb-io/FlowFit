namespace Apps.FlowFit.Models.Dtos;

public class DomainDTO 
{
    public string Description { get; set; }
    public string ModuleId { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}
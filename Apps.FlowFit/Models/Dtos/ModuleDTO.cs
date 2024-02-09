namespace Apps.FlowFit.Models.Dtos;

public class ModuleDTO 
{
    public string Description { get; set; }
    public string ProjectTemplateId { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}
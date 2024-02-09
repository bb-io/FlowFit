namespace Apps.FlowFit.Models.Dtos;

public class DocumentTypeDTO 
{
    public string ModuleId { get; set; }
    public string? Abrev { get; set; }
    public string? Description { get; set; }
    public ModuleDTO? Module { get; set; }
    public IEnumerable<DocumentTypeDictionaryDTO>? DocumentTypeDictionaries { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
    public string? ModuleDescription { get; set; }
}
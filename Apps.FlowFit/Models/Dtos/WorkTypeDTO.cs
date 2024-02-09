namespace Apps.FlowFit.Models.Dtos;

public class WorkTypeDTO 
{
    public string Description { get; set; }
    public bool? DocumentAnalyse { get; set; }
    public bool UseSystemValuesExtension { get; set; }
    public string ProjectTemplateId { get; set; }
    public string ModuleId { get; set; }
    public string? AuthorizedExtensions { get; set; }
    public int SourceLangDisplayState { get; set; }
    public int TargetLangDisplayState { get; set; }
    public bool? IsAllowSameSourceAndTarget { get; set; }
    public int IsSourceDocumentMandatory { get; set; }
    public bool IsActive { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}
using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class WorkTypeResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public bool? DocumentAnalyse { get; set; }
    public string ProjectTemplateId { get; set; }
    public string ModuleId { get; set; }
    public ModuleResult? Module { get; set; }
    public string SourceLangDisplayState { get; set; }
    public string TargetLangDisplayState { get; set; }
    public bool? IsAllowSameSourceAndTarget { get; set; }
    public string IsSourceDocumentMandatory { get; set; }
    public bool IsActive { get; set; }
    public int WorkTypeSourceLangParam { get; set; }
    public int WorkTypeTargetLangParam { get; set; }
    public IEnumerable<WorkTypeDictionaryDTO>? WorkTypeDictionary { get; set; }
    public IEnumerable<DictionaryDescriptionResult>? DescriptionDictionary { get; set; }
    public string? AuthorizedExtensions { get; set; }
    public bool UseSystemValuesExtension { get; set; }
}
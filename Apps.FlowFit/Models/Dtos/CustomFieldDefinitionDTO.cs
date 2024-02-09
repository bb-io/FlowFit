namespace Apps.FlowFit.Models.Dtos;

public class CustomFieldDefinitionDTO 
{
    public string? Type { get; set; }
    public string? Description { get; set; }
    public string? RegExp { get; set; }
    public string? ClassName { get; set; }
    public string? DefaultValue { get; set; }
    public int? MaxLength { get; set; }
    public int? MinLength { get; set; }
    public string? CustomFieldName { get; set; }
    public string? Tooltip { get; set; }
    public string CustomFieldGroupId { get; set; }
    public string? FlowFitVisibility { get; set; }
    public string? ClientVisibility { get; set; }
    public string? DateFormat { get; set; }
    public bool? IsWholeNumber { get; set; }
    public int? NumOfDecimals { get; set; }
    public bool VisibilityTranslator { get; set; }
    public int? Order { get; set; }
    public bool AllTemplates { get; set; }
    public bool SortedList { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
    public IEnumerable<CustomFieldListItemDTO>? ListItems { get; set; }
}
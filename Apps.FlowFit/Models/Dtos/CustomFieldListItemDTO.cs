namespace Apps.FlowFit.Models.Dtos;

public class CustomFieldListItemDTO 
{
    public string Id { get; set; }
    public string CustomFieldsDefinitionId { get; set; }
    public string? Description { get; set; }
    public IEnumerable<DictionaryDescriptionDTO>? DescriptionDictionary { get; set; }
}
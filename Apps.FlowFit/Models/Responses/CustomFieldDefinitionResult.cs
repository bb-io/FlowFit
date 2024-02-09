using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class CustomFieldDefinitionResult 
{
    public string Id { get; set; }
    public string? CustomFieldName { get; set; }
    public string? Type { get; set; }
    public string? Visibility { get; set; }
    public string? Description { get; set; }
    public int? MinLength { get; set; }
    public int? MaxLength { get; set; }
    public IEnumerable<CustomFieldDefinitionItemResult>? ListItemValues { get; set; }
}
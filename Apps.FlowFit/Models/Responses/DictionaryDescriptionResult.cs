using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class DictionaryDescriptionResult 
{
    public string Id { get; set; }
    public string DictionaryId { get; set; }
    public string? Culture { get; set; }
    public string? Description { get; set; }
    public string? Tooltipdescription { get; set; }
}
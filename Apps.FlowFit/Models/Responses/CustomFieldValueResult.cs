using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class CustomFieldValueResult 
{
    public string Id { get; set; }
    public string? CustomFieldName { get; set; }
    public string? Value { get; set; }
    public string? Type { get; set; }
    public string ClassId { get; set; }
    public string? ClassName { get; set; }
}
using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class FieldKeyMapResult 
{
    public string Id { get; set; }
    public string? FieldKey { get; set; }
    public string? ClassName { get; set; }
}
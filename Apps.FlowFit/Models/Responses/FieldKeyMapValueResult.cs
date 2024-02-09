using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class FieldKeyMapValueResult 
{
    public string Id { get; set; }
    public string FieldKeyId { get; set; }
    public string? Culture { get; set; }
    public string? FieldValue { get; set; }
    public FieldKeyMapResult? FieldKeyMap { get; set; }
    public string? FieldKeyDescription { get; set; }
}
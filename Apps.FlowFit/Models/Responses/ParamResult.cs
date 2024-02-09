using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ParamResult 
{
    public string Id { get; set; }
    public string? Value { get; set; }
    public string? Type { get; set; }
}
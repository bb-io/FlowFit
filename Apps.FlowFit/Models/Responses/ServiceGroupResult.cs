using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ServiceGroupResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public int? PrintOrder { get; set; }
    public string? Abbreviation { get; set; }
    public bool? IsMandatory { get; set; }
    public int? ServiceType { get; set; }
}
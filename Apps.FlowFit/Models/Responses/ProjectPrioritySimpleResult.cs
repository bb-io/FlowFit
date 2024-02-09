using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ProjectPrioritySimpleResult 
{
    public string Id { get; set; }
    public string? Color { get; set; }
    public int? SortOrder { get; set; }
    public string? Description { get; set; }
}
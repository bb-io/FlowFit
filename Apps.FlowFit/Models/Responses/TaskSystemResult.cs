using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class TaskSystemResult 
{
    public string Id { get; set; }
    public string? Class { get; set; }
    public string? AssemblyLocation { get; set; }
    public string? Description { get; set; }
    public string? Parameters { get; set; }
    public bool? IsDeliverable { get; set; }
    public bool? IsAttachDocument { get; set; }
}
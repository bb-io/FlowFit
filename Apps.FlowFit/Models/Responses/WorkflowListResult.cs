using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class WorkflowListResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public string SourceDocumentId { get; set; }
    public DateTime? Deadline { get; set; }
    public string ProjectId { get; set; }
}
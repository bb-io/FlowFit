using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class WorkflowNotesResult 
{
    public string Id { get; set; }
    public string? Culture { get; set; }
    public string? Title { get; set; }
    public string? Note { get; set; }
    public string ParentId { get; set; }
    public string WorkflowId { get; set; }
    public string? ClassName { get; set; }
    public IEnumerable<WorkflowNotesResult>? Children { get; set; }
    public string ProjectId { get; set; }
    public string CreatedById { get; set; }
    public string? CreatedByClass { get; set; }
    public DateTime Date { get; set; }
    public string? SystemSource { get; set; }
    public string? TitleArguments { get; set; }
    public string? TitleAction { get; set; }
    public string? TitleMessage { get; set; }
    public bool IsSystemGeneratedNote { get; set; }
    public string? CreatedByName { get; set; }
    public string? UserCode { get; set; }
    public string? UserColor { get; set; }
    public IEnumerable<WorkflowNotesFilesResult>? Files { get; set; }
    public string? DisplayTitle { get; set; }
}
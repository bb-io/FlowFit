using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class WorkflowResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public string ProjectId { get; set; }
    public string ModuleId { get; set; }
    public string? ModuleDescription { get; set; }
    public string SourceDocumentId { get; set; }
    public string? SourceDocumentPath { get; set; }
    public string SourceDocumentGroupId { get; set; }
    public string? SourceDocumentFileName { get; set; }
    public string ClientId { get; set; }
    public string WorkflowStatusId { get; set; }
    public decimal? WorkflowPercentCompletion { get; set; }
    public string? WorkflowStatusColor { get; set; }
    public string? WorkflowStatusDescription { get; set; }
    public int? WorkflowStatusDisplayOrder { get; set; }
    public string? WorkflowTeam { get; set; }
    public string? SourceLanguage { get; set; }
    public string? TargetLanguage { get; set; }
    public bool IsLate { get; set; }
    public DateTime? Deadline { get; set; }
    public DateTime? ProjectDeadline { get; set; }
    public string MemoQDocumentGuid { get; set; }
    public string MemoQProjectGuid { get; set; }
    public IEnumerable<TeamWorkflowResult>? Team { get; set; }
    public IEnumerable<WorkflowNotesResult>? Notes { get; set; }
    public IEnumerable<WorkflowTasksResult>? Tasks { get; set; }
}
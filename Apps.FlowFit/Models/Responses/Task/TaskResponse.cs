using Apps.FlowFit.Models.Dtos.Task;
using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Responses.Task;

public class TaskResponse
{
    public TaskResponse(TaskDto task)
    {
        Id = task.Id;
        ProjectId = task.ProjectId;
        ServiceId = task.ServiceId;
        StatusId = task.StatusId;
        IsDeliverable = task.IsDeliverable;
        LanguageSourceId = task.LanguageSourceId;
        LanguageTargetId = task.LanguageTargetId;
        DocumentPath = task.DocumentPath;
        DocumentName = task.DocumentName;
        AssigneeId = task.User?.AssignToClassId;
        Deadline = task.Deadline;
        Instruction = task.Instruction;
    }
    
    [Display("ID")]
    public string Id { get; set; }
    
    [Display("Project ID")]
    public string ProjectId { get; set; }
    
    [Display("Service ID")]
    public string ServiceId { get; set; }
    
    [Display("Status ID")]
    public string StatusId { get; set; }
    
    [Display("Is deliverable")]
    public bool IsDeliverable { get; set; }
    
    [Display("Source language ID")]
    public string? LanguageSourceId { get; set; }
    
    [Display("Target language ID")]
    public string? LanguageTargetId { get; set; }
    
    [Display("Document path")]
    public string? DocumentPath { get; set; }
    
    [Display("Document name")]
    public string? DocumentName { get; set; }
    
    [Display("Assignee ID")]
    public string? AssigneeId { get; set; }
    
    public DateTime? Deadline { get; set; }
    
    public string? Instruction { get; set; }
}
using Apps.FlowFit.Models.Dtos.Task;
using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Responses.Task;

public class TaskListResponse
{
    public TaskListResponse(TaskListDto task)
    {
        Id = task.Id;
        ServiceId = task.ServiceId;
        TaskStatusId = task.TaskStatusId;
        DocumentPath = task.DocumentPath;
        AssigneeId = task.AssignToClassId;
        IsDeliverable = task.IsDeliverable;
        SourceLanguageId = task.SourceLanguageId;
        TargetLanguageId = task.TargetLanguageId;
        Instruction = task.Instruction;
    }
    
    [Display("ID")]
    public string Id { get; set; }
    
    [Display("Service ID")]
    public string ServiceId { get; set; }
    
    [Display("Task status ID")]
    public string TaskStatusId { get; set; }
    
    [Display("Document path")]
    public string? DocumentPath { get; set; }
    
    [Display("Assignee ID")]
    public string? AssigneeId { get; set; }
    
    [Display("Is deliverable")]
    public bool IsDeliverable { get; set; }
    
    [Display("Source language ID")]
    public string? SourceLanguageId { get; set; }
    
    [Display("Target language ID")]
    public string? TargetLanguageId { get; set; }
    
    public string? Instruction { get; set; }
}
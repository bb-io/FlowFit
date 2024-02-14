using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Dtos.Tasks;

public class TaskListDto
{
    [Display("ID")]
    public string Id { get; set; }
    
    [Display("Service ID")]
    public string ServiceId { get; set; }
    
    [Display("Task status ID")]
    public string TaskStatusId { get; set; }
    
    [Display("Document path")]
    public string? DocumentPath { get; set; }
    
    [Display("Assignee ID")]
    public string? AssignToClassId { get; set; }
    
    [Display("Is deliverable")]
    public bool IsDeliverable { get; set; }
    
    [Display("Source language ID")]
    public string? SourceLanguageId { get; set; }
    
    [Display("Target language ID")]
    public string? TargetLanguageId { get; set; }
    
    public string? Instruction { get; set; }
}
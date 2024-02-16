namespace Apps.FlowFit.Models.Dtos.Task;

public class TaskListDto
{
    public string Id { get; set; }
    public string ServiceId { get; set; }
    public string ServiceDescription { get; set; }
    public string TaskStatusId { get; set; }
    public string? DocumentPath { get; set; }
    public string? AssignToClassId { get; set; }
    public bool IsDeliverable { get; set; }
    public string? SourceLanguageId { get; set; }
    public string? TargetLanguageId { get; set; }
    public string? Instruction { get; set; }
    public string ProjectId { get; set; }
    public string ProjectTitle { get; set; }
    public string ProjectNumber { get; set; }
}
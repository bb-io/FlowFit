using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ProjectDocumentDeliverableItemResult 
{
    public string TaskId { get; set; }
    public string? Extension { get; set; }
    public string? FileName { get; set; }
    public string? FileContent { get; set; }
    public int ContentLength { get; set; }
    public string? WorkflowTargetLanguage { get; set; }
    public string? WorkflowSourceLanguage { get; set; }
    public DateTime ModificationDate { get; set; }
}
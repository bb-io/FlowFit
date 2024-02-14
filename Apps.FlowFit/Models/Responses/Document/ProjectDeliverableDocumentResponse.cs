using Apps.FlowFit.Models.Dtos.Document;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Files;

namespace Apps.FlowFit.Models.Responses.Document;

public class ProjectDeliverableDocumentResponse : FileWrapper
{
    public ProjectDeliverableDocumentResponse(ProjectDeliverableDocumentDto deliverableDocument, FileReference file)
    {
        TaskId = deliverableDocument.TaskId;
        WorkflowSourceLanguage = deliverableDocument.WorkflowSourceLanguage;
        WorkflowTargetLanguage = deliverableDocument.WorkflowTargetLanguage;
        File = file;
    }
    
    [Display("Task ID")]
    public string TaskId { get; set; }
    
    [Display("Workflow source language")]
    public string? WorkflowSourceLanguage { get; set; }
    
    [Display("Workflow target language")]
    public string? WorkflowTargetLanguage { get; set; }
}
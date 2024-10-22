using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Responses.Document;

public class DeliveredProjectDocumentResponse
{
    [Display("Task ID")] public string TaskId { get; set; } = default!;

    [Display("Extension")] public string Extension { get; set; } = default!;

    [Display("File name")] public string FileName { get; set; } = default!;

    [Display("File content")] public string FileContent { get; set; } = default!;
    
    [Display("Content length")] public int ContentLength { get; set; }
    
    [Display("Workflow target language")] public string WorkflowTargetLanguage { get; set; } = default!;
    
    [Display("Workflow source language")] public string WorkflowSourceLanguage { get; set; } = default!;
    
    [Display("Modification date")] public DateTime ModificationDate { get; set; }
}
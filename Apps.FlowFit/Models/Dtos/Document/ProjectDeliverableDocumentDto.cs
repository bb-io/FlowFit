namespace Apps.FlowFit.Models.Dtos.Document;

public class ProjectDeliverableDocumentDto : BaseProjectDocumentDto
{
    public string TaskId { get; set; }
    public string? WorkflowSourceLanguage { get; set; }
    public string? WorkflowTargetLanguage { get; set; }
}

public class DeliverableDocumentsWrapper
{
    public IEnumerable<ProjectDeliverableDocumentDto> DeliverableDocuments { get; set; }
}
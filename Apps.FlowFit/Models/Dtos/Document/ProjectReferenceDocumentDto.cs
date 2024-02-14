namespace Apps.FlowFit.Models.Dtos.Document;

public class ProjectReferenceDocumentDto : BaseProjectDocumentDto
{
    public string Id { get; set; }
    public string? Comment { get; set; }
    public string? ReferenceDocumentTypeId { get; set; }
}
namespace Apps.FlowFit.Models.Dtos;

public class ProjectDocumentDTO 
{
    public string Id { get; set; }
    public string ProjectId { get; set; }
    public DateTime? DateAdd { get; set; }
    public int? Words { get; set; }
    public int? Pages { get; set; }
    public string TypeId { get; set; }
    public bool? IsRenamed { get; set; }
    public int? VersionOf { get; set; }
    public int VersionNumber { get; set; }
    public string? Comment { get; set; }
    public string GroupDocId { get; set; }
    public bool IsArchived { get; set; }
    public DateTime? ArchivedDate { get; set; }
    public bool? IsFinal { get; set; }
    public bool? IsVisibleClient { get; set; }
    public bool? IsNewDocumentVersion { get; set; }
    public string? Extension { get; set; }
    public string? FileName { get; set; }
    public string? FileContent { get; set; }
    public int? ContentLength { get; set; }
    public DocumentTypeDTO? DocumentType { get; set; }
}
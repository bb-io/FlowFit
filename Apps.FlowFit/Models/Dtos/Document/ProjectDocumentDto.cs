namespace Apps.FlowFit.Models.Dtos.Document;

public class ProjectDocumentDto : BaseProjectDocumentDto
{
    public string Id { get; set; }
    public int Words { get; set; }
    public int Pages { get; set; }
    public int VersionNumber { get; set; }
    public string? Comment { get; set; }
    public bool IsArchived { get; set; }
    public bool IsFinal { get; set; }
}
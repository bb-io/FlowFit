namespace Apps.FlowFit.Models.Dtos.Project;

public class ProjectReferenceFileDto 
{
    public string ProjectDocumentId { get; set; }
    public string ProjectDocumentReferenceTypeId { get; set; }
    public string FileName { get; set; }
    public string FileContent { get; set; }
    public string? Comment { get; set; }
}
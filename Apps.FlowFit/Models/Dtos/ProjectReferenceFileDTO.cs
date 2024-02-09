namespace Apps.FlowFit.Models.Dtos;

public class ProjectReferenceFileDTO 
{
    public string ProjectDocumentReferenceTypeId { get; set; }
    public string? Comment { get; set; }
    public string ProjectDocumentId { get; set; }
    public string? FileName { get; set; }
    public string? FileContent { get; set; }
}
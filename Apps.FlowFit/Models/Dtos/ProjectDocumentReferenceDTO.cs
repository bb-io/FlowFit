namespace Apps.FlowFit.Models.Dtos;

public class ProjectDocumentReferenceDTO 
{
    public string ProjectId { get; set; }
    public string? Comment { get; set; }
    public string ProjectDocumentId { get; set; }
    public bool IsVisibleClient { get; set; }
    public bool IsVisibleFreelancer { get; set; }
    public string ReferenceDocumentTypeId { get; set; }
    public string? Extension { get; set; }
    public string? FileName { get; set; }
    public string? FileContent { get; set; }
    public int? ContentLength { get; set; }
}
namespace Apps.FlowFit.Models.Dtos;

public class ProjectDocumentFileDTO 
{
    public string ProjectId { get; set; }
    public FileDefaultDTO File { get; set; }
    public bool DoNotExecutePretranslation { get; set; }
}
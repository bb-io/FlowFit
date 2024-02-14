using Apps.FlowFit.Models.Dtos.Document;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Files;

namespace Apps.FlowFit.Models.Responses.Document;

public class ProjectDocumentResponse : FileWrapper
{
    public ProjectDocumentResponse(ProjectDocumentDto projectDocument, FileReference file)
    {
        Id = projectDocument.Id;
        Words = projectDocument.Words;
        Pages = projectDocument.Pages;
        Comment = projectDocument.Comment;
        VersionNumber = projectDocument.VersionNumber;
        IsArchived = projectDocument.IsArchived;
        IsFinal = projectDocument.IsFinal;
        File = file;
    }
    
    [Display("ID")]
    public string Id { get; set; }
    
    public int Words { get; set; }
    
    public int Pages { get; set; }
    
    public string Comment { get; set; }
    
    [Display("Version number")]
    public int VersionNumber { get; set; }
    
    [Display("Is archived")]
    public bool IsArchived { get; set; }
    
    [Display("Is final")]
    public bool IsFinal { get; set; }
}
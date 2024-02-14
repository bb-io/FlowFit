using Apps.FlowFit.Models.Dtos.Document;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Files;

namespace Apps.FlowFit.Models.Responses.Document;

public class ProjectReferenceDocumentResponse : FileWrapper
{
    public ProjectReferenceDocumentResponse(ProjectReferenceDocumentDto referenceDocument, FileReference file)
    {
        Id = referenceDocument.Id;
        Comment = referenceDocument.Comment;
        ReferenceDocumentTypeId = referenceDocument.ReferenceDocumentTypeId;
        File = file;
    }
    
    [Display("ID")]
    public string Id { get; set; }
    
    public string Comment { get; set; }
    
    [Display("Reference document type ID")]
    public string? ReferenceDocumentTypeId { get; set; }
}
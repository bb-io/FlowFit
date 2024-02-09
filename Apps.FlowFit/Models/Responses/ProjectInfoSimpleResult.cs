using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ProjectInfoSimpleResult 
{
    public int SourceDocuments { get; set; }
    public int SourceDocumentsTotalPages { get; set; }
    public int SourceDocumentsTotalWords { get; set; }
    public int ReferenceDocuments { get; set; }
}
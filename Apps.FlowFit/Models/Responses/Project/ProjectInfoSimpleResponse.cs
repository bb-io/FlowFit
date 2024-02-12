using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Responses.Project;

public class ProjectInfoSimpleResponse 
{
    [Display("Source documents")]
    public int SourceDocuments { get; set; }
    
    [Display("Source documents total pages")]
    public int SourceDocumentsTotalPages { get; set; }
    
    [Display("Source documents total words")]
    public int SourceDocumentsTotalWords { get; set; }
    
    [Display("Reference documents")]
    public int ReferenceDocuments { get; set; }
}
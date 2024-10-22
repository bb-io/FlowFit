using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Responses.Document;

public class ProjectDeliveredResponse
{
    [Display("Project ID")]
    public string ProjectId { get; set; } = string.Empty;
    
    public List<DeliveredProjectDocumentResponse> Documents { get; set; } = new();
}
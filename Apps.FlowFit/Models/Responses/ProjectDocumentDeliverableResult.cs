using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ProjectDocumentDeliverableResult 
{
    public int UndeliveredDocuments { get; set; }
    public IEnumerable<ProjectDocumentDeliverableItemResult>? DeliverableDocuments { get; set; }
}
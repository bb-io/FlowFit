using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Responses.Document;

public class UploadProjectDocumentResponse
{
    [Display("Project document ID")]
    public string ProjectDocumentId { get; set; } = default!;
}
using Blackbird.Applications.Sdk.Common.Files;

namespace Apps.FlowFit.Models.Requests.Document;

public class UploadSourceDocumentRequest
{
    public FileReference File { get; set; } = default!;
}
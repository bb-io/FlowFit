using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Dtos.Document;

public class DocumentSimpleDto
{
    [Display("Document ID")]
    public string Id { get; set; }
    
    [Display("Filename")]
    public string? FileName { get; set; }
}
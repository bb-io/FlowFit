using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Responses.Documents;

public class DocumentSimpleResult 
{
    [Display("Document ID")]
    public string Id { get; set; }
    
    [Display("Filename")]
    public string? FileName { get; set; }
}
using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Dtos.Document;

public class DocumentSimpleDto
{
    [Display("ID")]
    public string Id { get; set; }
    
    [Display("File name")]
    public string FileName { get; set; }
}
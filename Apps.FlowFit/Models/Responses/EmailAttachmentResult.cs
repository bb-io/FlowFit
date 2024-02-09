using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class EmailAttachmentResult 
{
    public string Id { get; set; }
    public string EmailId { get; set; }
    public string? File { get; set; }
    public string? FileName { get; set; }
}
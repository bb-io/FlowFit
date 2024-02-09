using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class EmailResult 
{
    public string Id { get; set; }
    public string ClassId { get; set; }
    public string? ClassName { get; set; }
    public string SenderClassId { get; set; }
    public string? SenderClassName { get; set; }
    public string? Subject { get; set; }
    public string? From { get; set; }
    public string? To { get; set; }
    public string? Cc { get; set; }
    public string? Cco { get; set; }
    public string? Bcc { get; set; }
    public string? Body { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? Status { get; set; }
    public string? ErrorMessage { get; set; }
    public bool Sent { get; set; }
    public DateTime? ProcessDate { get; set; }
    public string EmailLogId { get; set; }
    public int Priority { get; set; }
    public bool ZipAttachments { get; set; }
    public IEnumerable<EmailAttachmentResult>? EmailAttachments { get; set; }
}
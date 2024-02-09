using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ContactTypeResult 
{
    public string Id { get; set; }
    public bool IsDeliver { get; set; }
    public string? Description { get; set; }
}
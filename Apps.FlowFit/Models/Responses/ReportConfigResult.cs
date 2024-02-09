using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ReportConfigResult 
{
    public string Id { get; set; }
    public string? Label { get; set; }
    public DateTime DateCreated { get; set; }
    public string CreatorId { get; set; }
    public string? CreatorClass { get; set; }
    public bool IsActive { get; set; }
    public string? Category { get; set; }
}
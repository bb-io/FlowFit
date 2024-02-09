using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class TeamWorkflowResult 
{
    public int? TaskProposedCount { get; set; }
    public int? UnassignedCount { get; set; }
    public string? Code { get; set; }
    public int? NbTask { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Color { get; set; }
    public string? NameFormat { get; set; }
    public string? FullName { get; set; }
}
using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ResourceListResult 
{
    public string Id { get; set; }
    public string? Code { get; set; }
    public bool? IsActive { get; set; }
    public bool IsInternal { get; set; }
    public string? Color { get; set; }
    public string? Email { get; set; }
    public string? WorkPhoneNumber { get; set; }
    public bool IsProjectManager { get; set; }
    public string? CompleteName { get; set; }
    public string? ModulesDescription { get; set; }
    public string? Culture { get; set; }
    public IEnumerable<SupervisorDetailsResult>? SupervisorDetails { get; set; }
}
using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class RoleResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public bool IsAdmin { get; set; }
}
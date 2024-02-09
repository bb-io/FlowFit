using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ClientContactSimpleResult 
{
    public string Id { get; set; }
    public string ClientId { get; set; }
    public string? Client { get; set; }
    public string ClientDepartmentId { get; set; }
    public string? ClientDepartment { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
}
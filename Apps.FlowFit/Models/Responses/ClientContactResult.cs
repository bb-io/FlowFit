using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ClientContactResult 
{
    public string Id { get; set; }
    public string ClientId { get; set; }
    public string? Client { get; set; }
    public string? ClientCode { get; set; }
    public string TypeId { get; set; }
    public string? Type { get; set; }
    public string ClientDepartmentId { get; set; }
    public string? ClientDepartment { get; set; }
    public bool IsGroupAdmin { get; set; }
    public bool SeeAllRequests { get; set; }
    public bool AccessDepartment { get; set; }
    public bool AccessClient { get; set; }
    public bool ChangeClient { get; set; }
    public bool ChangeDepartment { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? TelephoneGeneral { get; set; }
    public string? TelephoneDirect { get; set; }
    public string? Fax { get; set; }
    public string? CellularPhone { get; set; }
    public string TimezoneId { get; set; }
    public string PositionId { get; set; }
    public string? Position { get; set; }
    public string TitleId { get; set; }
    public string? Title { get; set; }
    public bool? IsActive { get; set; }
    public string AuthenticationConfigurationClientPortalId { get; set; }
}
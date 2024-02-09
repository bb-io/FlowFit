namespace Apps.FlowFit.Models.Dtos;

public class ClientContactDTO 
{
    public string ClientId { get; set; }
    public string TypeId { get; set; }
    public string ClientDepartmentId { get; set; }
    public bool CopyProject { get; set; }
    public bool IsGroupAdmin { get; set; }
    public bool? IsActive { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Email { get; set; }
    public string? TelephoneGeneral { get; set; }
    public string? TelephoneDirect { get; set; }
    public string? Fax { get; set; }
    public string? CellularPhone { get; set; }
    public string Status { get; set; }
    public string TimezoneId { get; set; }
    public string PositionId { get; set; }
    public string GenderId { get; set; }
    public string TitleId { get; set; }
    public string? Title { get; set; }
    public string? Password { get; set; }
}
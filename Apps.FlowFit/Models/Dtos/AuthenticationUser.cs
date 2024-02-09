namespace Apps.FlowFit.Models.Dtos;

public class AuthenticationUser 
{
    public string? Login { get; set; }
    public string? Password { get; set; }
    public string? Culture { get; set; }
    public string? UserIp { get; set; }
    public string SystemSource { get; set; }
    public string? Browser { get; set; }
    public string? UserAgent { get; set; }
    public string? MachineName { get; set; }
    public string TimeZoneId { get; set; }
    public string TenantId { get; set; }
}
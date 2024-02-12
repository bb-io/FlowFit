namespace Apps.FlowFit.Models.Dtos;

public class SessionTokenDto 
{
    public string TokenValue { get; set; }
    public DateTime ExpirationDate { get; set; }
}
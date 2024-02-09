namespace Apps.FlowFit.Models.Dtos;

public class SessionTokenDTO 
{
    public string TokenValue { get; set; }
    public DateTime ExpirationDate { get; set; }
}
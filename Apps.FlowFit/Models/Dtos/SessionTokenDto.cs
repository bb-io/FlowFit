using Newtonsoft.Json;

namespace Apps.FlowFit.Models.Dtos;

public class SessionTokenDto 
{
    [JsonProperty("tokenValue")]
    public string TokenValue { get; set; }
    
    public DateTime ExpirationDate { get; set; }
}
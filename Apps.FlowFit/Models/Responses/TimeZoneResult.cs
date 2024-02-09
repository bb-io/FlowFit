using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class TimeZoneResult 
{
    public string Id { get; set; }
    public string? DisplayName { get; set; }
    public string? BaseUtcOffset { get; set; }
}
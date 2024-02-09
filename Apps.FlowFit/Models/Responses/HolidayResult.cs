using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class HolidayResult 
{
    public string Id { get; set; }
    public string HolidayNameId { get; set; }
    public string? Name { get; set; }
    public DateTime Date { get; set; }
}
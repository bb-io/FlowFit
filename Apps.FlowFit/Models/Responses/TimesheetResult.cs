using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class TimesheetResult 
{
    public string Id { get; set; }
    public string ResourceId { get; set; }
    public string? ResourceName { get; set; }
    public DateTime StartPeriod { get; set; }
    public DateTime EndPeriod { get; set; }
    public int? ValidatedBy { get; set; }
    public bool IsValidated { get; set; }
    public DateTime? ValidatedOn { get; set; }
    public string? Comment { get; set; }
    public IEnumerable<TimesheetItemResult>? TimesheetItems { get; set; }
}
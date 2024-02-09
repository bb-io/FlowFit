using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class TimesheetSummaryResult 
{
    public string TimesheetId { get; set; }
    public string ResourceId { get; set; }
    public string? ResourceName { get; set; }
    public string? Code { get; set; }
    public string? Color { get; set; }
    public decimal? WorkedHours { get; set; }
    public decimal? NonWorkedHours { get; set; }
    public decimal Overtime { get; set; }
    public decimal? TotalHours { get; set; }
    public bool? IsValidated { get; set; }
    public DateTime? ValidationDate { get; set; }
    public string? ValidatedBy { get; set; }
    public string? Comments { get; set; }
    public string SupervisorId { get; set; }
}
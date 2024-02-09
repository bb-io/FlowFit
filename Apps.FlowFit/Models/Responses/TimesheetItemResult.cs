using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class TimesheetItemResult 
{
    public string Id { get; set; }
    public string TimesheetId { get; set; }
    public DateTime? StartPeriod { get; set; }
    public DateTime? EndPeriod { get; set; }
    public string ResourceId { get; set; }
    public string WorkId { get; set; }
    public string? WorkCode { get; set; }
    public string TaskId { get; set; }
    public string? ChargeCode { get; set; }
    public string ClientId { get; set; }
    public DateTime Date { get; set; }
    public int? TimeSpent { get; set; }
    public decimal? HourlyRate { get; set; }
    public DateTime? CreatedOn { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public int? ModifiedBy { get; set; }
    public string? Comment { get; set; }
    public string? WorkCodeDescription { get; set; }
    public string ProjectId { get; set; }
    public decimal? OverHeadCost { get; set; }
}
using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class TaskResult 
{
    public string Id { get; set; }
    public string ProjectId { get; set; }
    public string? ProjectNumber { get; set; }
    public string? ProjectTitle { get; set; }
    public string ProjectModuleId { get; set; }
    public string? Number { get; set; }
    public string ServiceId { get; set; }
    public string StatusId { get; set; }
    public string? Status { get; set; }
    public string LanguageSourceId { get; set; }
    public string? LanguageSource { get; set; }
    public string LanguageTargetId { get; set; }
    public string? LanguageTarget { get; set; }
    public TaskUserResult? User { get; set; }
    public DateTime? Deadline { get; set; }
    public bool? IsDeliverable { get; set; }
    public DateTime? DeliveryDate { get; set; }
    public string? DocumentPath { get; set; }
    public string? DocumentName { get; set; }
    public string? Instruction { get; set; }
    public decimal? Quantity { get; set; }
    public string UnitId { get; set; }
    public int? PercentCompletion { get; set; }
    public decimal? EstimatedTime { get; set; }
    public string? ServiceDescription { get; set; }
    public bool? IsValidation { get; set; }
    public bool IsUrgent { get; set; }
    public bool IsBillableClient { get; set; }
    public bool IsBillableToProvider { get; set; }
}
using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ProjectSearchListResult 
{
    public string Id { get; set; }
    public string? ProjectNumber { get; set; }
    public string StatusId { get; set; }
    public string? StatusDescription { get; set; }
    public int? StatusDisplayOrder { get; set; }
    public string? StatusColor { get; set; }
    public bool? IsUrgent { get; set; }
    public bool? IsReopened { get; set; }
    public string? Title { get; set; }
    public string ProductId { get; set; }
    public string? ProductDescription { get; set; }
    public string ProductAreaId { get; set; }
    public string? ProductAreaDescription { get; set; }
    public string ProjectTypeId { get; set; }
    public string? ProjectTypeDescription { get; set; }
    public string WorkTypeId { get; set; }
    public string? WorkTypeDescription { get; set; }
    public string DomainId { get; set; }
    public string? DomainDescription { get; set; }
    public string? Readership { get; set; }
    public string? TargetAudience { get; set; }
    public string? CostCenter { get; set; }
    public string SourceLanguageId { get; set; }
    public string? SourceLanguage { get; set; }
    public string? TargetLanguage { get; set; }
    public string ClientId { get; set; }
    public string? ClientName { get; set; }
    public string? ClientCode { get; set; }
    public string ClientGroupId { get; set; }
    public string ClientDepartmentId { get; set; }
    public string? ClientDepartmentDescription { get; set; }
    public string? ClientGroup { get; set; }
    public string RequesterId { get; set; }
    public string? RequesterName { get; set; }
    public string ClassificationId { get; set; }
    public string? ClassificationDescription { get; set; }
    public string ManagerId { get; set; }
    public string? ManagerName { get; set; }
    public string Manager2Id { get; set; }
    public string PriorityId { get; set; }
    public string? PriorityColor { get; set; }
    public int? PrioritySortOrder { get; set; }
    public string? PriorityDescription { get; set; }
    public string ModuleId { get; set; }
    public string? ModuleDescription { get; set; }
    public int IsLateInteger { get; set; }
    public int? Docs { get; set; }
    public decimal? WeightedWords { get; set; }
    public int? Words { get; set; }
    public int? Pages { get; set; }
    public string ChargeCodeId { get; set; }
    public DateTime? Deadline { get; set; }
    public DateTime? CreationDate { get; set; }
    public DateTime? DeliveryDate { get; set; }
    public DateTime? CompletedDate { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? DateArchival { get; set; }
    public DateTime? RequestedDeadline { get; set; }
    public DateTime? NegociatedDeadline { get; set; }
    public string? JobCode { get; set; }
    public string DelayReasonId { get; set; }
    public string? DelayReasonDescription { get; set; }
    public string DeadlineNegotiatedId { get; set; }
    public bool IsActive { get; set; }
    public string? Detail { get; set; }
    public string? Team { get; set; }
    public string? Culture { get; set; }
    public bool IsLate { get; set; }
    public IEnumerable<TeamResult>? ProjectTeam { get; set; }
    public string? Languages { get; set; }
}
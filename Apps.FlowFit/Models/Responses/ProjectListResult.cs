using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ProjectListResult 
{
    public string Id { get; set; }
    public string? ProjectNumber { get; set; }
    public ClientSimpleResult? Client { get; set; }
    public string ClientDepartmentId { get; set; }
    public string? ClientDepartment { get; set; }
    public string ModuleId { get; set; }
    public string? Module { get; set; }
    public string WorkTypeId { get; set; }
    public string? WorkType { get; set; }
    public string? Title { get; set; }
    public StatusResult? Status { get; set; }
    public string? ChargeCode { get; set; }
    public string DomainId { get; set; }
    public string? Domain { get; set; }
    public DateTime? CreationDate { get; set; }
    public DateTime? CompletedDate { get; set; }
    public string TypeId { get; set; }
    public string? Type { get; set; }
    public ResourceSimpleResult? Manager { get; set; }
    public ResourceSimpleResult? Manager2 { get; set; }
    public DelayReasonResult? DelayReason { get; set; }
    public ChargeCodeResult? CostCenter { get; set; }
    public DateTime? StartDate { get; set; }
    public bool IsUrgent { get; set; }
    public DateTime? DeliveryDate { get; set; }
    public bool IsNew { get; set; }
    public DateTime? Deadline { get; set; }
    public DateTime? RequestedDeadline { get; set; }
    public DateTime? NegotiatedDeadline { get; set; }
    public ClientContactSimpleResult? Requester { get; set; }
    public string TargetAudienceId { get; set; }
    public string? TargetAudience { get; set; }
    public ProjectPrioritySimpleResult? Priority { get; set; }
    public string ReadershipId { get; set; }
    public string? Readership { get; set; }
    public string ProductId { get; set; }
    public string? Product { get; set; }
    public string ProductAreaId { get; set; }
    public string? ProductArea { get; set; }
    public string TemplateId { get; set; }
    public string? Template { get; set; }
    public bool IsNewRequestedDeadline { get; set; }
    public LanguageSimpleResult? SourceLanguage { get; set; }
    public IEnumerable<LanguageSimpleResult>? TargetLanguages { get; set; }
    public ProjectInfoSimpleResult? ProjectInfo { get; set; }
    public string CreatorId { get; set; }
    public string? CreatorClassName { get; set; }
    public DateTime? DateArchival { get; set; }
}
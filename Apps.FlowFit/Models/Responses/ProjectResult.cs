using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ProjectResult 
{
    public string Id { get; set; }
    public string? ProjectNumber { get; set; }
    public ClientSimpleResult? Client { get; set; }
    public string ClientDepartmentId { get; set; }
    public string? ClientDepartment { get; set; }
    public StatusResult? Status { get; set; }
    public string ModuleId { get; set; }
    public string? Module { get; set; }
    public string WorkTypeId { get; set; }
    public string? WorkType { get; set; }
    public string? JobCode { get; set; }
    public string? JobCodeDescription { get; set; }
    public string? Title { get; set; }
    public string? Detail { get; set; }
    public string? PrevProjectNumber { get; set; }
    public string DomainId { get; set; }
    public string? Domain { get; set; }
    public LanguageSimpleResult? SourceLanguage { get; set; }
    public string? ClientRequirements { get; set; }
    public string TypeId { get; set; }
    public string? Type { get; set; }
    public ResourceSimpleResult? Manager { get; set; }
    public ResourceSimpleResult? Manager2 { get; set; }
    public DateTime? StartDate { get; set; }
    public bool IsUrgent { get; set; }
    public bool IsQuoteRequested { get; set; }
    public DateTime? Deadline { get; set; }
    public DateTime? RequestedDeadline { get; set; }
    public string? DeliveringEmail { get; set; }
    public ClientContactSimpleResult? Requester { get; set; }
    public ClientContactSimpleResult? Applicant { get; set; }
    public bool IsNegotiableDeadline { get; set; }
    public string NegotiableDeadlineId { get; set; }
    public string? NegotiableDeadline { get; set; }
    public string DelayReasonId { get; set; }
    public string? DelayReason { get; set; }
    public string TargetAudienceId { get; set; }
    public string? TargetAudience { get; set; }
    public ProjectPrioritySimpleResult? Priority { get; set; }
    public string ReadershipId { get; set; }
    public string? Readership { get; set; }
    public bool? IsCertificationRequired { get; set; }
    public bool? SpeakerNote { get; set; }
    public string ProductId { get; set; }
    public string? Product { get; set; }
    public string ProductAreaId { get; set; }
    public string? ProductArea { get; set; }
    public string TemplateId { get; set; }
    public string? Template { get; set; }
    public bool AutomaticArchiving { get; set; }
    public bool CloseOnDelivery { get; set; }
    public string ChargeCodeId { get; set; }
    public string? ChargeCode { get; set; }
    public IEnumerable<LanguageSimpleResult>? TargetLanguages { get; set; }
    public IEnumerable<ProjectContactDTO>? ProjectContacts { get; set; }
    public decimal? Quote { get; set; }
    public ProjectInfoSimpleResult? ProjectInfo { get; set; }
    public DateTime? NegotiatedDeadline { get; set; }
    public DateTime? CompletedDate { get; set; }
    public DateTime? DeliveryDate { get; set; }
    public DateTime? DateArchival { get; set; }
    public DateTime? CancellationDate { get; set; }
    public DateTime? CreationDate { get; set; }
    public string CreatorId { get; set; }
    public string? CreatorClassName { get; set; }
    public IEnumerable<SimpleDocumentResult>? ProjectSourceDocuments { get; set; }
    public IEnumerable<SimpleDocumentResult>? ProjectReferenceDocuments { get; set; }
}
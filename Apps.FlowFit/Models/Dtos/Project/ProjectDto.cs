using Apps.FlowFit.Models.Dtos.Client;
using Apps.FlowFit.Models.Dtos.Document;
using Apps.FlowFit.Models.Dtos.Language;
using Apps.FlowFit.Models.Dtos.Resource;

namespace Apps.FlowFit.Models.Dtos.Project;

public class ProjectDto 
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string? ProjectNumber { get; set; }
    public ClientSimpleDto Client { get; set; }
    public string ClientDepartmentId { get; set; }
    public string? ClientDepartment { get; set; }
    public StatusDto Status { get; set; }
    public string WorkTypeId { get; set; }
    public string? WorkType { get; set; }
    public string? Detail { get; set; }
    public string? PrevProjectNumber { get; set; }
    public LanguageSimpleDto? SourceLanguage { get; set; }
    public IEnumerable<LanguageSimpleDto>? TargetLanguages { get; set; }
    public string? ClientRequirements { get; set; }
    public ResourceSimpleDto? Manager { get; set; }
    public bool IsUrgent { get; set; }
    public ClientContactSimpleDto Requester { get; set; }
    public ProjectPrioritySimpleDto? Priority { get; set; }
    public string TemplateId { get; set; }
    public string? Template { get; set; }
    public bool CloseOnDelivery { get; set; }
    public bool AutomaticArchiving { get; set; }
    public IEnumerable<ProjectContactDto>? ProjectContacts { get; set; }
    public ProjectInfoSimpleDto? ProjectInfo { get; set; }
    public bool IsNegotiableDeadline { get; set; }
    public DateTime? CreationDate { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? RequestedDeadline { get; set; }
    public DateTime? NegotiatedDeadline { get; set; }
    public DateTime? CompletedDate { get; set; }
    public DateTime? DeliveryDate { get; set; }
    public DateTime? DateArchival { get; set; }
    public DateTime? CancellationDate { get; set; }
    public string? NegotiableDeadlineId { get; set; }
    public string? NegotiableDeadline { get; set; }
    public string? DelayReasonId { get; set; }
    public string? DelayReason { get; set; }
    public string CreatorId { get; set; }
    public string? DomainId { get; set; }
    public string? Domain { get; set; }
    public IEnumerable<DocumentSimpleDto>? ProjectSourceDocuments { get; set; }
    public IEnumerable<DocumentSimpleDto>? ProjectReferenceDocuments { get; set; }
}
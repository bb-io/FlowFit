namespace Apps.FlowFit.Models.Dtos;

public class ProjectDTO 
{
    public string ClientId { get; set; }
    public string ClientDepartmentId { get; set; }
    public string ModuleId { get; set; }
    public string WorkTypeId { get; set; }
    public string? JobCode { get; set; }
    public string? JobCodeDescription { get; set; }
    public string Title { get; set; }
    public string? PrevProjectNumber { get; set; }
    public string DomainId { get; set; }
    public string SourceLanguageId { get; set; }
    public string TypeId { get; set; }
    public string ManagerId { get; set; }
    public string Manager2Id { get; set; }
    public DateTime? StartDate { get; set; }
    public bool IsUrgent { get; set; }
    public bool IsQuoteRequested { get; set; }
    public DateTime? RequestedDeadline { get; set; }
    public string? DeliveringEmail { get; set; }
    public string ProjectRequesterId { get; set; }
    public string ApplicantId { get; set; }
    public bool IsNegotiableDeadline { get; set; }
    public string TargetAudienceId { get; set; }
    public string PriorityId { get; set; }
    public string ReadershipId { get; set; }
    public bool? IsCertificationRequired { get; set; }
    public bool? SpeakerNote { get; set; }
    public string ProductId { get; set; }
    public string ProductAreaId { get; set; }
    public string TemplateId { get; set; }
    public string ChargeCodeId { get; set; }
    public string? ChargeCode { get; set; }
    public IEnumerable<int>? TargetLanguages { get; set; }
    public IEnumerable<ProjectContactDTO>? ProjectContacts { get; set; }
    public string? Detail { get; set; }
    public string ClassificationId { get; set; }
    public decimal? Quote { get; set; }
    public string? ShortText { get; set; }
    public IEnumerable<ProjectFileDTO>? SourceFiles { get; set; }
    public IEnumerable<ProjectReferenceFileDTO>? ReferenceFiles { get; set; }
}
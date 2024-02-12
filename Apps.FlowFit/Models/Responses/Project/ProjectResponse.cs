using Apps.FlowFit.Models.Dtos.Project;
using Apps.FlowFit.Models.Responses.Client;
using Apps.FlowFit.Models.Responses.Documents;
using Apps.FlowFit.Models.Responses.Language;
using Apps.FlowFit.Models.Responses.Resource;
using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Responses.Project;

public class ProjectResponse 
{
    [Display("Project ID")]
    public string Id { get; set; }
    
    public string Title { get; set; }
    
    [Display("Project number")]
    public string? ProjectNumber { get; set; }
    
    public ClientSimpleResponse? Client { get; set; }
    
    [Display("Client department ID")]
    public string ClientDepartmentId { get; set; }
    
    [Display("Client department")]
    public string? ClientDepartment { get; set; }
    
    public StatusResponse? Status { get; set; }
    
    [Display("Work type ID")]
    public string WorkTypeId { get; set; }
    
    [Display("Work type")]
    public string? WorkType { get; set; }
    
    public string? Detail { get; set; }
    
    [Display("Previous project number")]
    public string? PrevProjectNumber { get; set; }
    
    [Display("Source language")]
    public LanguageSimpleResponse? SourceLanguage { get; set; }
    
    [Display("Target languages")]
    public IEnumerable<LanguageSimpleResponse>? TargetLanguages { get; set; }
    
    [Display("Client requirements")]
    public string? ClientRequirements { get; set; }
    
    [Display("Project manager")]
    public ResourceSimpleResponse? Manager { get; set; }
    
    [Display("Start date")]
    public DateTime? StartDate { get; set; }
    
    [Display("Is urgent")]
    public bool IsUrgent { get; set; }
    
    public DateTime? Deadline { get; set; }
    
    [Display("Requested deadline")]
    public DateTime? RequestedDeadline { get; set; }
    
    public ClientContactSimpleResponse? Requester { get; set; }
    
    [Display("Is negotiable deadline")]
    public bool IsNegotiableDeadline { get; set; }

    public ProjectPrioritySimpleResponse? Priority { get; set; }
    
    [Display("Template ID")]
    public string TemplateId { get; set; }
    
    public string? Template { get; set; }
    
    [Display("Close on delivery")]
    public bool CloseOnDelivery { get; set; }
    
    [Display("Project contacts")]
    public IEnumerable<ProjectContactDto>? ProjectContacts { get; set; }
    
    [Display("Project info")]
    public ProjectInfoSimpleResponse? ProjectInfo { get; set; }
    
    [Display("Negotiated deadline")]
    public DateTime? NegotiatedDeadline { get; set; }
    
    [Display("Completed date")]
    public DateTime? CompletedDate { get; set; }
   
    [Display("Delivery date")]
    public DateTime? DeliveryDate { get; set; }
   
    [Display("Date archival")]
    public DateTime? DateArchival { get; set; }
    
    [Display("Cancellation date")]
    public DateTime? CancellationDate { get; set; }
    
    [Display("Creation date")]
    public DateTime? CreationDate { get; set; }
    
    [Display("Creator ID")]
    public string CreatorId { get; set; }
    
    [Display("Project source documents")]
    public IEnumerable<DocumentSimpleResult>? ProjectSourceDocuments { get; set; }
    
    [Display("Project reference documents")]
    public IEnumerable<DocumentSimpleResult>? ProjectReferenceDocuments { get; set; }
}
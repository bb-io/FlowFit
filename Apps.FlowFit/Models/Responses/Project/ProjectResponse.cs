using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos.Client;
using Apps.FlowFit.Models.Dtos.Document;
using Apps.FlowFit.Models.Dtos.Language;
using Apps.FlowFit.Models.Dtos.Project;
using Apps.FlowFit.Models.Dtos.Resource;
using Apps.FlowFit.Models.Dtos.Task;
using Apps.FlowFit.Models.Responses.Task;
using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Responses.Project;

public class ProjectResponse
{
    private ProjectResponse(ProjectDto project)
    {
        Id = project.Id;
        Title = project.Title;
        ProjectNumber = project.ProjectNumber;
        Details = project.Detail;
        PrevProjectNumber = project.PrevProjectNumber;
        IsUrgent = project.IsUrgent;
        CloseOnDelivery = project.CloseOnDelivery;
        AutomaticArchiving = project.AutomaticArchiving;
        CreatorId = project.CreatorId;
        Status = project.Status;
        WorkTypeId = project.WorkTypeId;
        SourceLanguage = project.SourceLanguage;
        TargetLanguages = project.TargetLanguages;
        TemplateId = project.TemplateId;
        Client = project.Client;
        ClientDepartmentId = project.ClientDepartmentId;
        ClientRequirements = project.ClientRequirements;
        Manager = project.Manager;
        Requester = project.Requester;
        ProjectContacts = project.ProjectContacts;
        PriorityId = project.Priority?.Id;
        ProjectInfo = project.ProjectInfo;
        DatesInformation = new()
        {
            IsNegotiableDeadline = project.IsNegotiableDeadline,
            CreationDate = project.CreationDate,
            StartDate = project.StartDate,
            RequestedDeadline = project.RequestedDeadline,
            NegotiatedDeadline = project.NegotiatedDeadline,
            CompletedDate = project.CompletedDate,
            DeliveryDate = project.DeliveryDate,
            DateArchival = project.DateArchival,
            CancellationDate = project.CancellationDate,
            NegotiableDeadlineId = project.NegotiableDeadlineId,
            DelayReasonId = project.DelayReasonId
        };
        DomainId = project.DomainId;
        ProjectSourceDocuments = project.ProjectSourceDocuments;
        ProjectReferenceDocuments = project.ProjectReferenceDocuments;
    }
    
    [Display("Project ID")]
    public string Id { get; set; }
    
    public string Title { get; set; }
    
    [Display("Project number")]
    public string? ProjectNumber { get; set; }
    
    public string? Details { get; set; }
    
    [Display("Previous project number")]
    public string? PrevProjectNumber { get; set; }
    
    [Display("Is urgent")]
    public bool IsUrgent { get; set; }
    
    [Display("Close on delivery")]
    public bool CloseOnDelivery { get; set; }
    
    [Display("Automatic archiving")]
    public bool AutomaticArchiving { get; set; }
    
    [Display("Creator ID")]
    public string CreatorId { get; set; }
    
    public StatusDto Status { get; set; }
    
    [Display("Work type ID")]
    public string WorkTypeId { get; set; }
    
    [Display("Source language")]
    public LanguageSimpleDto? SourceLanguage { get; set; }
    
    [Display("Target languages")]
    public IEnumerable<LanguageSimpleDto>? TargetLanguages { get; set; }
    
    [Display("Template ID")]
    public string TemplateId { get; set; }
    
    public ClientSimpleDto Client { get; set; }
    
    [Display("Client department ID")]
    public string? ClientDepartmentId { get; set; }
    
    [Display("Client requirements")]
    public string? ClientRequirements { get; set; }
    
    [Display("Project manager")]
    public ResourceSimpleDto? Manager { get; set; }
    
    public ClientContactSimpleDto Requester { get; set; }
    
    [Display("Project contacts")]
    public IEnumerable<ProjectContactDto>? ProjectContacts { get; set; }
    
    [Display("Priority ID")]
    public string? PriorityId { get; set; }
    
    [Display("Project info")]
    public ProjectInfoSimpleDto? ProjectInfo { get; set; }
    
    [Display("Dates information")]
    public DatesInformation DatesInformation { get; set; }
    
    [Display("Domain ID")]
    public string? DomainId { get; set; } 
    
    public IEnumerable<TaskListResponse>? Tasks { get; set; }
    
    [Display("Source documents")]
    public IEnumerable<DocumentSimpleDto>? ProjectSourceDocuments { get; set; }
    
    [Display("Reference documents")]
    public IEnumerable<DocumentSimpleDto>? ProjectReferenceDocuments { get; set; }

    public static async Task<ProjectResponse> Create(FlowFitClient client, ProjectDto project)
    {
        var getProjectTasksRequest = new FlowFitRequest($"/api/v1/Tasks?projectId={project.Id}");
        var tasks = await client.ExecuteWithErrorHandling<IEnumerable<TaskListDto>>(getProjectTasksRequest);
        return new(project) { Tasks = tasks.Select(task => new TaskListResponse(task)) };
    }
}

public class DatesInformation
{
    [Display("Is negotiable deadline")]
    public bool IsNegotiableDeadline { get; set; }
    
    [Display("Creation date")]
    public DateTime? CreationDate { get; set; }
    
    [Display("Start date")]
    public DateTime? StartDate { get; set; }
    
    [Display("Requested deadline")]
    public DateTime? RequestedDeadline { get; set; }
    
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
    
    [Display("Negotiable deadline ID")]
    public string? NegotiableDeadlineId { get; set; }
    
    [Display("Delay reason ID")]
    public string? DelayReasonId { get; set; }
}
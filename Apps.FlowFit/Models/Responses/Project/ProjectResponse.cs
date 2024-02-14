using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Dtos.Client;
using Apps.FlowFit.Models.Dtos.Document;
using Apps.FlowFit.Models.Dtos.Language;
using Apps.FlowFit.Models.Dtos.Project;
using Apps.FlowFit.Models.Dtos.Resource;
using Apps.FlowFit.Models.Dtos.Tasks;
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
        WorkType = new() { Id = project.WorkTypeId, Description = project.WorkType };
        SourceLanguage = project.SourceLanguage;
        TargetLanguages = project.TargetLanguages;
        Template = new() { Id = project.TemplateId, Description = project.Template };
        Client = project.Client;
        ClientDepartment = new() { Id = project.ClientDepartmentId, Description = project.ClientDepartment };
        ClientRequirements = project.ClientRequirements;
        Manager = project.Manager;
        Requester = project.Requester;
        ProjectContacts = project.ProjectContacts;
        Priority = project.Priority;
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
            NegotiableDeadline = new() { Id = project.NegotiableDeadlineId, Description = project.NegotiableDeadline },
            DelayReason = new() { Id = project.DelayReasonId, Description = project.DelayReason }
        };
        Domain = new() { Id = project.DomainId, Description = project.Domain };
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
    
    [Display("Work type")]
    public EntitySimpleDto WorkType { get; set; }
    
    [Display("Source language")]
    public LanguageSimpleDto? SourceLanguage { get; set; }
    
    [Display("Target languages")]
    public IEnumerable<LanguageSimpleDto>? TargetLanguages { get; set; }
    
    public EntitySimpleDto Template { get; set; }
    
    public ClientSimpleDto Client { get; set; }
    
    [Display("Client department")]
    public EntitySimpleDto? ClientDepartment { get; set; }
    
    [Display("Client requirements")]
    public string? ClientRequirements { get; set; }
    
    [Display("Project manager")]
    public ResourceSimpleDto? Manager { get; set; }
    
    public ClientContactSimpleDto Requester { get; set; }
    
    [Display("Project contacts")]
    public IEnumerable<ProjectContactDto>? ProjectContacts { get; set; }
    
    public ProjectPrioritySimpleDto? Priority { get; set; }
    
    [Display("Project info")]
    public ProjectInfoSimpleDto? ProjectInfo { get; set; }
    
    [Display("Dates information")]
    public DatesInformation DatesInformation { get; set; }
    
    public EntitySimpleDto? Domain { get; set; } 
    
    public IEnumerable<TaskListDto>? Tasks { get; set; }
    
    [Display("Source documents")]
    public IEnumerable<DocumentSimpleDto>? ProjectSourceDocuments { get; set; }
    
    [Display("Reference documents")]
    public IEnumerable<DocumentSimpleDto>? ProjectReferenceDocuments { get; set; }

    public static async Task<ProjectResponse> Create(FlowFitClient client, ProjectDto project)
    {
        var getProjectTasksRequest = new FlowFitRequest($"/api/v1/Tasks?projectId={project.Id}");
        var tasks = await client.ExecuteWithErrorHandling<IEnumerable<TaskListDto>>(getProjectTasksRequest);
        return new(project) { Tasks = tasks };
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
    
    [Display("Negotiable deadline")]
    public EntitySimpleDto? NegotiableDeadline { get; set; }
    
    [Display("Delay reason")]
    public EntitySimpleDto? DelayReason { get; set; }
}
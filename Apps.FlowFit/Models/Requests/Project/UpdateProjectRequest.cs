using Apps.FlowFit.DataSourceHandlers;
using Apps.FlowFit.DataSourceHandlers.Project;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.FlowFit.Models.Requests.Project;

public class UpdateProjectRequest
{
    public string? Title { get; set; }
    
    [Display("Status ID")]
    [DataSource(typeof(ProjectStatusDataSourceHandler))]
    public string? StatusId { get; set; }
    
    [Display("Work type ID")]
    [DataSource(typeof(WorkTypeDataSourceHandler))]
    public string? WorkTypeId { get; set; }
    
    [Display("Template ID")]
    [DataSource(typeof(ProjectTemplateDataSourceHandler))]
    public string? TemplateId { get; set; }
    
    [Display("Is urgent")]
    public bool? IsUrgent { get; set; }
    
    [Display("Close on delivery")]
    public bool? CloseOnDelivery { get; set; }
    
    [Display("Automatic archiving")]
    public bool? AutomaticArchiving { get; set; }
    
    [Display("Source language ID")]
    [DataSource(typeof(LanguageDataSourceHandler))]
    public string? SourceLanguageId { get; set; }
    
    [Display("Target language IDs")]
    [DataSource(typeof(LanguageDataSourceHandler))]
    public IEnumerable<string>? TargetLanguageIds { get; set; }
    
    [Display("Project manager ID")]
    [DataSource(typeof(ResourceDataSourceHandler))]
    public string? ManagerId { get; set; }
    
    [Display("Is negotiable deadline")]
    public bool? IsNegotiableDeadline { get; set; }
    
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
    
    [Display("Delay reason ID")]
    [DataSource(typeof(DelayReasonDataSourceHandler))]
    public string? DelayReasonId { get; set; }
    
    [Display("Negotiable deadline reason ID")]
    [DataSource(typeof(NegotiableDeadlineDataSourceHandler))]
    public string? NegotiableDeadlineId { get; set; }
    
    public string? Details { get; set; }
}
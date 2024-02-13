using Apps.FlowFit.DataSourceHandlers;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Files;

namespace Apps.FlowFit.Models.Requests.Project;

public class CreateProjectRequest
{
    public string Title { get; set; }
    
    [Display("Work type ID")]
    [DataSource(typeof(WorkTypeDataSourceHandler))]
    public string WorkTypeId { get; set; }
    
    [Display("Template ID")]
    [DataSource(typeof(ProjectTemplateDataSourceHandler))]
    public string TemplateId { get; set; }
    
    [Display("Project requester ID")]
    [DataSource(typeof(ClientContactDataSourceHandler))]
    public string ProjectRequesterId { get; set; }
    
    [Display("Source language ID")]
    [DataSource(typeof(LanguageDataSourceHandler))]
    public string? SourceLanguageId { get; set; }
    
    [Display("Target language IDs")]
    [DataSource(typeof(LanguageDataSourceHandler))]
    public IEnumerable<string>? TargetLanguageIds { get; set; }
    
    [Display("Client department ID")]
    [DataSource(typeof(ClientDepartmentDataSourceHandler))]
    public string? ClientDepartmentId { get; set; }
    
    [Display("Project manager ID")]
    [DataSource(typeof(ResourceDataSourceHandler))]
    public string? ManagerId { get; set; }
    
    [Display("Requested deadline")]
    public DateTime? RequestedDeadline { get; set; }
    
    public string? Details { get; set; }
    
    [Display("Source files")]
    public IEnumerable<FileReference>? SourceFiles { get; set; }
}
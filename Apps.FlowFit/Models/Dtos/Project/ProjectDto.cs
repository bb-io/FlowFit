using Apps.FlowFit.Extensions;
using Apps.FlowFit.Models.Identifiers;
using Apps.FlowFit.Models.Requests.Project;
using Blackbird.Applications.SDK.Extensions.FileManagement.Interfaces;

namespace Apps.FlowFit.Models.Dtos.Project;

public class ProjectDto 
{
    public ProjectDto(CreateProjectRequest input, ClientIdentifier clientIdentifier,
        IFileManagementClient fileManagementClient)
    {
        ClientId = int.Parse(clientIdentifier.ClientId);
        WorkTypeId = int.Parse(input.WorkTypeId);
        Title = input.Title;
        IsUrgent = input.IsUrgent ?? false;
        ProjectRequesterId = int.Parse(input.ProjectRequesterId);
        TemplateId = int.Parse(input.TemplateId);
        ClientDepartmentId = int.TryParse(input.ClientDepartmentId, out var departmentId) ? departmentId : null;
        SourceLanguageId = int.TryParse(input.SourceLanguageId, out var sourceLanguageId) ? sourceLanguageId : null;
        ManagerId = int.TryParse(input.ManagerId, out var managerId) ? managerId : null;
        RequestedDeadline = input.RequestedDeadline;
        IsNegotiableDeadline = input.IsNegotiableDeadline;
        Detail = input.Detail;
        TargetLanguages = input.TargetLanguageIds?.Select(int.Parse);
        SourceFiles = input.SourceFiles?.Select(file => new ProjectFileDto
        {
            FileName = file.Name,
            FileContent = fileManagementClient.DownloadAsync(file).Result.ConvertToBase64String().Result
        });
    }
    
    public int ClientId { get; set; }
    public int WorkTypeId { get; set; }
    public string Title { get; set; }
    public bool IsUrgent { get; set; }
    public int ProjectRequesterId { get; set; }
    public int TemplateId { get; set; }
    public int? ClientDepartmentId { get; set; }
    public int? SourceLanguageId { get; set; }
    public int? ManagerId { get; set; }
    public DateTime? RequestedDeadline { get; set; }
    public bool? IsNegotiableDeadline { get; set; }
    public string? Detail { get; set; }
    public IEnumerable<int>? TargetLanguages { get; set; }
    public IEnumerable<ProjectFileDto>? SourceFiles { get; set; }
}
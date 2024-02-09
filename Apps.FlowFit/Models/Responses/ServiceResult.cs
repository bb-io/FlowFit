using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ServiceResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public string? Code { get; set; }
    public string SourceLanguageId { get; set; }
    public string? SourceLanguage { get; set; }
    public string TargetLanguageId { get; set; }
    public string? TargetLanguage { get; set; }
    public string ServiceGroupId { get; set; }
    public string? ServiceGroup { get; set; }
    public string ServiceCategoryId { get; set; }
    public string? ServiceCategory { get; set; }
    public bool IsAttachFile { get; set; }
    public string ServiceUnitId { get; set; }
    public string? ServiceUnit { get; set; }
    public decimal? Quantity { get; set; }
    public int? MinimumEstimatedTime { get; set; }
    public int? Round { get; set; }
    public bool IsAssignedToProjectManager { get; set; }
    public string AssignToClassId { get; set; }
    public string? AssignToClassName { get; set; }
    public string TaskSystemId { get; set; }
    public string? TaskSystemParameters { get; set; }
    public string? ProjectWorkDocumentNamingPattern { get; set; }
    public string RequireDocumentOnCompletion { get; set; }
    public string ServiceValidationId { get; set; }
    public bool IsAssignedToRequester { get; set; }
    public bool IsAssignedToApplicant { get; set; }
    public string WorkCodeId { get; set; }
    public string? WorkCode { get; set; }
    public string RequireLogTimeOnCompletionExternalProvider { get; set; }
    public string? ArchiveFolderName { get; set; }
    public string? ArchiveFolderNameSuffix { get; set; }
    public string? DocumentSuffix { get; set; }
    public bool IsUseComputedWords { get; set; }
    public bool IsValidation { get; set; }
}
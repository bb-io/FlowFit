using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class TaskSearchListResult 
{
    public string Id { get; set; }
    public string? ServiceUnityDescription { get; set; }
    public decimal? Quantity { get; set; }
    public string? UserColor { get; set; }
    public string? UserCode { get; set; }
    public string? UserName { get; set; }
    public string TaskDisplayId { get; set; }
    public string ServiceId { get; set; }
    public string ProjectStatusId { get; set; }
    public string? ServiceDescription { get; set; }
    public string? TaskStatusDescription { get; set; }
    public string? ProjectStatusDescription { get; set; }
    public string TaskStatusId { get; set; }
    public string? TaskStatusColor { get; set; }
    public string? ProjectNumber { get; set; }
    public string? ProjectTitle { get; set; }
    public string? ClientName { get; set; }
    public string? ClientCode { get; set; }
    public string? RequesterName { get; set; }
    public string ClientId { get; set; }
    public int? PercentCompletion { get; set; }
    public string? DocumentPath { get; set; }
    public DateTime? CompletedDate { get; set; }
    public string ProjectId { get; set; }
    public string AssignToClassId { get; set; }
    public string? AssignToClassName { get; set; }
    public string ModuleId { get; set; }
    public string ManagerId { get; set; }
    public string Manager2Id { get; set; }
    public string ClientDepartmentId { get; set; }
    public string WorkflowModuleId { get; set; }
    public DateTime? TaskDeadline { get; set; }
    public decimal? EstimatedTime { get; set; }
    public int? LoggedTime { get; set; }
    public DateTime? PercentCompletionModificationDate { get; set; }
    public string ServiceUnityId { get; set; }
    public DateTime? DeliveryDate { get; set; }
    public string ServiceGroupId { get; set; }
    public int TaskSystem { get; set; }
    public bool IsDeliverable { get; set; }
    public string? ProjectPriorityColor { get; set; }
    public int? ProjectPrioritySortOrder { get; set; }
    public string? ProjectPriorityDescription { get; set; }
    public int? IsOverdue { get; set; }
    public DateTime? AssignedDate { get; set; }
    public DateTime? StartDate { get; set; }
    public string? PurchaseOrderNumber { get; set; }
    public string? Culture { get; set; }
    public string WorkflowId { get; set; }
    public DateTime? ReadyDate { get; set; }
    public string SourceLanguageId { get; set; }
    public string? SourceLanguage { get; set; }
    public string TargetLanguageId { get; set; }
    public string? TargetLanguage { get; set; }
    public string? Instruction { get; set; }
    public int? CompletionCounter { get; set; }
    public DateTime? ScheduledDate { get; set; }
    public int? PercentCompleted { get; set; }
    public bool? ValidationStatus { get; set; }
    public string? QuantityService { get; set; }
    public string? DocumentName { get; set; }
    public string? EstimatedTimeConverted { get; set; }
    public string? LoggedTimeConverted { get; set; }
    public bool IsTaskSystem { get; set; }
    public bool TaskOverdue { get; set; }
}
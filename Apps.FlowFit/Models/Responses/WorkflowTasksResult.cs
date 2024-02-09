using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class WorkflowTasksResult 
{
    public string Id { get; set; }
    public string TaskId { get; set; }
    public string DisplayId { get; set; }
    public int? DisplayOrder { get; set; }
    public string WorkflowId { get; set; }
    public string ProjectId { get; set; }
    public string ServiceId { get; set; }
    public string? ServiceDescription { get; set; }
    public string ServiceGroupId { get; set; }
    public string AssignToClassId { get; set; }
    public string? AssignToClassName { get; set; }
    public string? CompleteName { get; set; }
    public string? UserColor { get; set; }
    public string? UserCode { get; set; }
    public bool IsInternal { get; set; }
    public string? DocumentPath { get; set; }
    public string? DocumentFileName { get; set; }
    public string StatusId { get; set; }
    public string? StatusColor { get; set; }
    public string? StatusDescription { get; set; }
    public string SourceLanguageId { get; set; }
    public string? SourceLanguageAbrev { get; set; }
    public string? SourceLanguageDescription { get; set; }
    public string TargetLanguageId { get; set; }
    public string? TargetLanguageAbrev { get; set; }
    public string? TargetLanguageDescription { get; set; }
    public decimal? EstimatedTime { get; set; }
    public bool? IsDeliverable { get; set; }
    public bool? IsAssignedToProjectManager { get; set; }
    public bool IsTaskSystem { get; set; }
    public string UnitId { get; set; }
    public string? UnitDescription { get; set; }
    public decimal? Quantity { get; set; }
    public string? Instruction { get; set; }
    public int? PercentCompletion { get; set; }
    public string? SupplierReference { get; set; }
    public decimal? TimeSpent { get; set; }
    public int? CountTimeSheetItems { get; set; }
    public string WorkCodeId { get; set; }
    public string ClientId { get; set; }
    public int CompletionCounter { get; set; }
    public bool? ValidationStatus { get; set; }
    public bool IsValidation { get; set; }
    public string PurchaseOrderId { get; set; }
    public string PurchaseOrderDisplayId { get; set; }
    public bool IsMemoQService { get; set; }
    public DateTime? Deadline { get; set; }
    public DateTime? DeliveryDate { get; set; }
    public string? ErrorMessage { get; set; }
    public DateTime? PercentCompletionModificationDate { get; set; }
    public DateTime? DownloadDate { get; set; }
    public bool IsChecked { get; set; }
    public DateTime? ReadyDate { get; set; }
    public DateTime? AssignedDate { get; set; }
    public DateTime? CompletedDate { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? TaskDeadline { get; set; }
    public string ServiceCategoryId { get; set; }
}
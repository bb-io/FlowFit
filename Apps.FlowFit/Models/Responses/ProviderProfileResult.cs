using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ProviderProfileResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public bool Title { get; set; }
    public bool Type { get; set; }
    public bool WordsDetail { get; set; }
    public bool Detail { get; set; }
    public bool Context { get; set; }
    public bool IsClientInfo { get; set; }
    public bool DisplayClientRequirements { get; set; }
    public bool DisplayProjectDeadline { get; set; }
    public bool DisplayProjectManager1 { get; set; }
    public bool DisplayProjectManager2 { get; set; }
    public bool DisplayTargetAudience { get; set; }
    public bool DisplayRequesterInfo { get; set; }
    public bool IsDefault { get; set; }
    public bool IsChargeCode { get; set; }
    public bool IsProjectPriority { get; set; }
    public bool IsInvoiceMenu { get; set; }
    public bool IsPCard { get; set; }
    public bool EmailEndTask { get; set; }
    public bool IsDisplayTasksToBill { get; set; }
    public bool IsDisplayPurchaseOrdersToBill { get; set; }
    public bool DisplayApplicantInfo { get; set; }
}
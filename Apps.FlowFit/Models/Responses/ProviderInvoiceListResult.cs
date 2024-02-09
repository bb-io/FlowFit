using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ProviderInvoiceListResult 
{
    public string Id { get; set; }
    public string DisplayId { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime? ReceivedOn { get; set; }
    public DateTime? DueOn { get; set; }
    public DateTime? PaidOn { get; set; }
    public DateTime? ApprovedOn { get; set; }
    public decimal NetTotal { get; set; }
    public string TaxId { get; set; }
    public string? TaxDescription { get; set; }
    public string StatusId { get; set; }
    public string? StatusDescription { get; set; }
    public string? StatusColor { get; set; }
    public string ResourceId { get; set; }
    public string? ResourceCompleteName { get; set; }
    public string? ResourceColor { get; set; }
    public string? ResourceCodeOrInitials { get; set; }
    public bool ResourceIsInternal { get; set; }
    public int? ApprovedBy { get; set; }
    public string? ApprovedByCompleteName { get; set; }
    public string? ApprovedByColor { get; set; }
    public string? ApprovedByCodeOrInitials { get; set; }
    public bool? ApprovedByIsInternal { get; set; }
    public string CurrencyId { get; set; }
    public string? CurrencyISOCode { get; set; }
    public string DocumentId { get; set; }
    public string? DocumentName { get; set; }
    public decimal NetTotalConvertedToBaseCurrency { get; set; }
    public string? ProjectDescription { get; set; }
    public string? ProjectNumbers { get; set; }
    public string? PurchaseOrders { get; set; }
    public string? PurchaseOrderNumber { get; set; }
    public string? Culture { get; set; }
    public decimal? EstimatedCost { get; set; }
}
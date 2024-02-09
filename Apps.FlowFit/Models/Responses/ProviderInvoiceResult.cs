using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ProviderInvoiceResult 
{
    public string Id { get; set; }
    public string DisplayId { get; set; }
    public decimal Subtotal { get; set; }
    public decimal NetTotal { get; set; }
    public decimal Total { get; set; }
    public string TaxId { get; set; }
    public string? Comment { get; set; }
    public string ResourceId { get; set; }
    public string StatusId { get; set; }
    public DateTime? ReceivedOn { get; set; }
    public DateTime? DueOn { get; set; }
    public DateTime? PaidOn { get; set; }
    public int CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public int? ModifiedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public int? ApprovedBy { get; set; }
    public DateTime? ApprovedOn { get; set; }
    public string CurrencyId { get; set; }
    public int? DiscountType { get; set; }
    public decimal? DiscountRate { get; set; }
    public decimal? DiscountAmount { get; set; }
    public decimal? MinimumCost { get; set; }
    public decimal? DiscountValue { get; set; }
    public decimal? Tax1Rate { get; set; }
    public decimal? Tax2Rate { get; set; }
    public decimal? Tax1Amount { get; set; }
    public decimal? Tax2Amount { get; set; }
    public IEnumerable<ProviderInvoiceItemResult>? Items { get; set; }
    public string? Status { get; set; }
    public string? Currency { get; set; }
    public string? Provider { get; set; }
    public string? Tax { get; set; }
}
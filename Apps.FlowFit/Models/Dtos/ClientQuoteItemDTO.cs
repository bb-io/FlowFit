namespace Apps.FlowFit.Models.Dtos;

public class ClientQuoteItemDTO 
{
    public string Id { get; set; }
    public string ClientQuoteId { get; set; }
    public string ClientServiceId { get; set; }
    public int DisplayOrder { get; set; }
    public string? Description { get; set; }
    public string? SecondaryDescription { get; set; }
    public string? Detail { get; set; }
    public decimal Subtotal { get; set; }
    public decimal NetTotal { get; set; }
    public decimal Total { get; set; }
    public int? DiscountType { get; set; }
    public decimal? DiscountRate { get; set; }
    public decimal? DiscountAmount { get; set; }
    public decimal? DiscountValue { get; set; }
    public decimal? SurchargeRate { get; set; }
    public decimal? SurchargeValue { get; set; }
    public IEnumerable<ClientQuoteSubItemDTO>? SubItems { get; set; }
}
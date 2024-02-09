namespace Apps.FlowFit.Models.Dtos;

public class ClientQuoteDTO 
{
    public string Id { get; set; }
    public string ProjectId { get; set; }
    public string ClientId { get; set; }
    public string CurrencyId { get; set; }
    public string StatusId { get; set; }
    public DateTime? ValidityDate { get; set; }
    public string? BillingAddress { get; set; }
    public string? ShippingAddress { get; set; }
    public string? CustomerComment { get; set; }
    public string? InternalComment { get; set; }
    public decimal Subtotal { get; set; }
    public decimal? MinimumCost { get; set; }
    public decimal NetTotal { get; set; }
    public decimal Total { get; set; }
    public string TaxId { get; set; }
    public FinancialTaxExtendedDTO? Tax { get; set; }
    public decimal? Tax1Rate { get; set; }
    public decimal? Tax1Amount { get; set; }
    public decimal? Tax2Rate { get; set; }
    public decimal? Tax2Amount { get; set; }
    public string ClientPriceDefinitionId { get; set; }
    public string DocumentTemplateId { get; set; }
    public string CommunicationLanguageId { get; set; }
    public string ClientContactId { get; set; }
    public IEnumerable<ClientQuoteItemDTO>? Items { get; set; }
    public DateTime CreationDate { get; set; }
}